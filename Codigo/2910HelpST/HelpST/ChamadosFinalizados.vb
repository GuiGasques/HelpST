Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class ChamadosFinalizados
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    Dim dtbAmbiente As New DataTable
    Dim dtbComponente As New DataTable
    Public Codigo As String
    Dim dtbChamadosFinalizados As New DataTable
	Private Sub ChamadosFinalizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label2.Text = variaveis.Login
		variaveis.con.Open()
		Dim sql As String
		sql = "select login_user, Hierarquia from usuario where login_user = @user and senha = @senha"
		Dim cmd As New SqlCommand(sql, con)
		cmd.Parameters.AddWithValue("@user", variaveis.Login)
		cmd.Parameters.AddWithValue("@senha", variaveis.senha)
		adp.SelectCommand = cmd
		dtb.Clear()
        adp.Fill(dtb)
        variaveis.con.Close()

		gridChamadosFinalizados.DataSource = dtbChamadosFinalizados

		variaveis.con.Open()

        variaveis.Ambiente()
        Dim linha As DataRow = dtbLocal.NewRow()
        linha("Cod_Ambiente") = 0
        linha("Sala") = "-- Selecione --"
        dtbLocal.Rows.InsertAt(linha, 0)
        cbSalas.DisplayMember = "Sala"
        cbSalas.ValueMember = "Cod_Ambiente"
        cbSalas.DataSource = dtbLocal

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

    Private Sub gridChamadosFinalizados_MouseClick(sender As Object, e As MouseEventArgs) Handles gridChamadosFinalizados.MouseClick
        Dim Titulo As String
        Dim linha As Integer
        Dim Descriçao As String
        Dim Usuario As String
        Dim Sala As String
        Dim Computador As String
        Dim Data As String
        Dim Andamento As String
        Dim Nivel As String
        Dim Comentario As String

        linha = gridChamadosFinalizados.CurrentRow.Index

        Codigo = dtbChamadosFinalizados.Rows(linha).Item(0).ToString()
        ChamadoFinalizado.Cod_Chamado = Codigo
        Titulo = dtbChamadosFinalizados.Rows(linha).Item(1).ToString()
        ChamadoFinalizado.Label2.Text = Titulo

        Sala = dtbChamadosFinalizados.Rows(linha).Item(4).ToString()
        ChamadoFinalizado.Label8.Text = Sala

        Computador = dtbChamadosFinalizados.Rows(linha).Item(3).ToString()
        ChamadoFinalizado.Label10.Text = Computador

        Descriçao = dtbChamadosFinalizados.Rows(linha).Item(2).ToString()
        ChamadoFinalizado.rtTexto.Text = Descriçao

        Usuario = dtbChamadosFinalizados.Rows(linha).Item(5).ToString()
        ChamadoFinalizado.Label6.Text = Usuario

        Data = dtbChamadosFinalizados.Rows(linha).Item(7).ToString()
        ChamadoFinalizado.Label12.Text = Data

        Andamento = dtbChamadosFinalizados.Rows(linha).Item(8).ToString()
        ChamadoFinalizado.Label14.Text = Andamento

        Nivel = dtbChamadosFinalizados.Rows(linha).Item(9).ToString()
        ChamadoFinalizado.Label16.Text = Nivel



        variaveis.con.Open()
        Dim cmd2 As New SqlCommand("Select Comentar from Manutencao where Cod_Chamado = '" & Codigo & "'", variaveis.con)
        cmd2.ExecuteNonQuery()
        Comentario = cmd2.ExecuteScalar
        variaveis.con.Close()
        ChamadoFinalizado.Label3.Text = Comentario

        ChamadoFinalizado.Show()

    End Sub
    Private Sub filtrarChamados()

        dtbChamadosFinalizados.Clear()
        Dim salaSelecionada = variaveis.retornaItemSelecionado(cbSalas.SelectedItem, "Cod_Ambiente")
        Dim pcSelecionado = variaveis.retornaItemSelecionado(cbPc.SelectedItem, "Cod_Componente")

        Dim queryString = "Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala, c.Dia_Hora,c.Andamento,c.Nivel from Chamados c,Usuario u, Componente p, Ambiente a where c.Cod_User = u.Cod_User And p.Cod_Componente = c.Cod_Componente And a.Cod_Ambiente = c.Cod_Ambiente And u.Usuario ='" & variaveis.Login & "' And c.Andamento = 'Finalizado'"
        If variaveis.isAdmin Then
            queryString = "Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,u.Usuario,u.Cargo, c.Dia_Hora,c.Andamento,c.Nivel from Chamados c,Usuario u, Componente p, Ambiente a where c.Cod_User = u.Cod_User And p.Cod_Componente = c.Cod_Componente And a.Cod_Ambiente = c.Cod_Ambiente And c.Andamento = 'Finalizado'"
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
        dtbChamadosFinalizados.Clear()
        adp.Fill(dtbChamadosFinalizados)
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
        Dim cmd1 As New SqlCommand("Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,c.Dia_Hora,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente and a.Sala Like  '%" & cbSalas.Text & "%' and c.Excluidos = 'Excluido'", variaveis.con)
        adp.SelectCommand = cmd1
        dtbChamadosFinalizados.Clear()
        adp.Fill(dtbChamadosFinalizados)
        variaveis.con.Close()
    End Sub
End Class