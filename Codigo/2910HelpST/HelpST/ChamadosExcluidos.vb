Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class ChamadosExcluidos
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    Dim dtbAmbiente As New DataTable
    Dim dtbComponente As New DataTable
    Public Codigo As String
    Dim dtbChamadosExcluidos As New DataTable
	Private Sub ChamadosExcluidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = variaveis.Login
		variaveis.con.Open()
		Dim sql As String
		sql = "select login_user, Hierarquia from usuario where login_user = @user and senha = @senha"
		'sql = "select login, Hierarquia  from usuario where login = @user and senha = @senha"
		Dim cmd As New SqlCommand(sql, con)
		cmd.Parameters.AddWithValue("@user", variaveis.Login)
		cmd.Parameters.AddWithValue("@senha", variaveis.senha)
		adp.SelectCommand = cmd
		dtb.Clear()
		adp.Fill(dtb)
		If (dtb.Rows.Count > 0) Then
			Select Case dtb.Rows(0).Item(1).ToString()
				Case "Administrador"
					AtualizaGridManutecao()
					variaveis.con.Close()
				Case "Usuario"
					AtualizaGridUser()
					variaveis.con.Close()
			End Select
			variaveis.con.Close()
		End If
		variaveis.con.Close()
		gridChamadosExcluidos.DataSource = dtbChamadosExcluidos

        variaveis.con.Close()
        variaveis.con.Open()
        Dim dtbSalas As New DataTable
        Dim cmd2 As New SqlCommand("Select Cod_Ambiente, Sala from Ambiente", variaveis.con)
        adp.SelectCommand = cmd2
        dtbSalas.Clear()
        adp.Fill(dtbSalas)

        Dim linha As DataRow = dtbSalas.NewRow()
        linha("Cod_Ambiente") = 0
        linha("Sala") = "-- Selecione --"
        dtbSalas.Rows.InsertAt(linha, 0)
        cbSalas.DisplayMember = "Sala"
        cbSalas.ValueMember = "Cod_Ambiente"
        cbSalas.DataSource = dtbSalas
        variaveis.con.Close()


        cbCargo.Items.Add("Professor")
        cbCargo.Items.Add("Coordenador")
        cbCargo.Items.Add("Secretaria")
        cbCargo.Items.Add("Manutençao")
        cbCargo.Items.Insert(0, "-- Selecione --")
        cbCargo.SelectedIndex = 0

        If Not variaveis.isAdmin Then
            cbCargo.Visible = False
            MetroLabel3.Visible = False
        End If
    End Sub

	Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
		variaveis.fechaForm()
		Me.Close()

	End Sub
	Private Sub AtualizaGridUser()
		variaveis.con.Close()
		variaveis.con.Open()
        Dim cmd As New SqlCommand("Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,c.Dia_Hora,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente  and c.Excluidos = 'Excluido' and c.Cod_User = " & TelaLogin.Cod_user, variaveis.con)
		Dim adp As New SqlDataAdapter()
		adp.SelectCommand = cmd
		dtbChamadosExcluidos.Clear()
		adp.Fill(dtbChamadosExcluidos)
		variaveis.con.Close()
	End Sub

	Private Sub AtualizaGridManutecao()
		variaveis.con.Close()
		variaveis.con.Open()
        Dim cmd As New SqlCommand("Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,c.Dia_Hora,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente  and c.Excluidos = 'Excluido'", variaveis.con)
		Dim adp As New SqlDataAdapter()
		adp.SelectCommand = cmd
		dtbChamadosExcluidos.Clear()
		adp.Fill(dtbChamadosExcluidos)
		variaveis.con.Close()
	End Sub
	Private Sub cbSalas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSalas.SelectedIndexChanged
        dtbPC.Clear()
        variaveis.con.Close()
        Dim codAmbiente = variaveis.retornaItemSelecionado(cbSalas.SelectedItem, "Cod_Ambiente")


        Dim cmd1 As New SqlCommand("Select Cod_Componente, Pc from Componente where Cod_Ambiente = '" & codAmbiente & "'", variaveis.con)
        adp.SelectCommand = cmd1
        dtbComponente.Clear()
        adp.Fill(dtbPC)

        Dim linha As DataRow = dtbPC.NewRow()
        linha("Cod_Componente") = 0
        linha("Pc") = "-- Selecione --"
        dtbPC.Rows.InsertAt(linha, 0)

        cbPc.DataSource = dtbPC
        cbPc.ValueMember = "Cod_Componente"
        cbPc.DisplayMember = "Pc"
        cbPc.SelectedIndex = 0
        variaveis.con.Close()
        filtrarChamados()

    End Sub
    Private Sub gridChamadosExcluidos_MouseClick(sender As Object, e As MouseEventArgs) Handles gridChamadosExcluidos.MouseClick
        Dim Titulo As String
        Dim linha As Integer
        Dim Descriçao As String
        Dim Usuario As String
        Dim Sala As String
        Dim Computador As String
        Dim Data As String
        Dim Andamento As String
        Dim Nivel As String

        Codigo = dtbChamadosExcluidos.Rows(linha).Item(0).ToString()

        linha = gridChamadosExcluidos.CurrentRow.Index
        Titulo = dtbChamadosExcluidos.Rows(linha).Item(1).ToString()
        Chamado.Label3.Text = Titulo


        Sala = dtbChamadosExcluidos.Rows(linha).Item(4).ToString()
        Chamado.Label9.Text = Sala


        Computador = dtbChamadosExcluidos.Rows(linha).Item(3).ToString()
        Chamado.Label11.Text = Computador


        Descriçao = dtbChamadosExcluidos.Rows(linha).Item(2).ToString()
        Chamado.Label14.Text = Descriçao


        Usuario = dtbChamadosExcluidos.Rows(linha).Item(5).ToString()
        Chamado.Label16.Text = Usuario


        Data = dtbChamadosExcluidos.Rows(linha).Item(7).ToString()
        Chamado.Label2.Text = Data


        Andamento = dtbChamadosExcluidos.Rows(linha).Item(8).ToString()
        Chamado.Label6.Text = Andamento


        Nivel = dtbChamadosExcluidos.Rows(linha).Item(9).ToString()

        Chamado.Label4.Text = Nivel

        Chamado.btnResponder.Visible = False
        Chamado.Show()
    End Sub

    Private Sub filtrarChamados()
        dtbChamadosExcluidos.Clear()
        Dim salaSelecionada = variaveis.retornaItemSelecionado(cbSalas.SelectedItem, "Cod_Ambiente")
        Dim pcSelecionado = variaveis.retornaItemSelecionado(cbPc.SelectedItem, "Cod_Componente")

        Dim queryString = "Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala, c.Dia_Hora,c.Nivel,c.Excluidos from Chamados c,Usuario u, Componente p, Ambiente a where c.Cod_User = u.Cod_User And p.Cod_Componente = c.Cod_Componente And a.Cod_Ambiente = c.Cod_Ambiente And u.Usuario ='" & variaveis.Login & "' And c.Excluidos = 'Excluido'"
        If variaveis.isAdmin Then
            queryString = "Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,u.Usuario,u.Cargo, c.Dia_Hora,c.Nivel,c.Excluidos from Chamados c,Usuario u, Componente p, Ambiente a where c.Cod_User = u.Cod_User And p.Cod_Componente = c.Cod_Componente And a.Cod_Ambiente = c.Cod_Ambiente And c.Excluidos = 'Excluido'"
        End If

        If Not salaSelecionada = 0 Then
            queryString += " And c.Cod_Ambiente = " & salaSelecionada
        End If

        If Not pcSelecionado = 0 Then
            queryString += " And c.Cod_Componente = " & pcSelecionado
        End If

        If Not cbCargo.SelectedIndex = 0 Then
            queryString += " And u.Cargo Like  '%" & cbCargo.SelectedItem & "%'"
        End If

        variaveis.con.Close()

        variaveis.con.Open()
        Dim cmd1 As New SqlCommand(queryString, variaveis.con)
        adp.SelectCommand = cmd1
        dtbChamadosExcluidos.Clear()
        adp.Fill(dtbChamadosExcluidos)
        variaveis.con.Close()
    End Sub
    Private Sub cbPc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPc.SelectedIndexChanged
        filtrarChamados()
    End Sub

    Private Sub cbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargo.SelectedIndexChanged
        filtrarChamados()
    End Sub
    Private Sub cbSalas_TextChanged(sender As Object, e As EventArgs) Handles cbSalas.TextChanged
        variaveis.con.Close()
        variaveis.con.Open()
        Dim cmd1 As New SqlCommand("Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,c.Dia_Hora,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente and a.Sala Like  '%" & cbSalas.Text & "%' and c.Andamento = 'Finalizado'", variaveis.con)
        adp.SelectCommand = cmd1
        dtbChamadosExcluidos.Clear()
        adp.Fill(dtbChamadosExcluidos)
        variaveis.con.Close()
    End Sub
End Class