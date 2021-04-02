Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class Chamados
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    Dim dtbAmbiente As New DataTable
    Dim dtbComponente As New DataTable
    Dim dtbUser As New DataTable
    Dim dtbLocal As New DataTable
	Public dtbChamados As New DataTable
    Dim Nome As String
    Public Codigo As String
    Public Sub Chamados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = variaveis.Login
        gridChamados.DataSource = dtbChamados

        variaveis.con.Open()
        Dim dtbSalas As New DataTable
        Dim cmd As New SqlCommand("Select Cod_Ambiente, Sala from Ambiente", variaveis.con)
        adp.SelectCommand = cmd
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

        AtualizaGrid()
    End Sub

    Public Sub AtualizaGrid()
        filtrarChamados()
    End Sub

    Public Sub gridChamados_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridChamados.CellMouseClick
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

        Codigo = Convert.ToInt32(dtbChamados.Rows(linha).Item(0).ToString())

        linha = gridChamados.CurrentRow.Index
        Titulo = dtbChamados.Rows(linha).Item(1).ToString()
        Chamado.Cod_Chamado = Codigo
        Chamado.Label3.Text = Titulo
        ChamadoFinalizado.Label2.Text = Titulo

		Sala = dtbChamados.Rows(linha).Item(4).ToString()
		Chamado.Label9.Text = Sala
		ChamadoFinalizado.Label8.Text = Sala

		Computador = dtbChamados.Rows(linha).Item(3).ToString()
		Chamado.Label11.Text = Computador
		ChamadoFinalizado.Label10.Text = Computador

		Descriçao = dtbChamados.Rows(linha).Item(2).ToString()
        Chamado.Label14.Text = Descriçao
        ChamadoFinalizado.rtTexto.Text = Descriçao


        If variaveis.isAdmin Then
            Usuario = dtbChamados.Rows(linha).Item(5).ToString()
            Chamado.Label16.Text = Usuario
            ChamadoFinalizado.Label6.Text = Usuario

            Data = dtbChamados.Rows(linha).Item(7).ToString()
            Chamado.Label2.Text = Data
            ChamadoFinalizado.Label12.Text = Data

            Andamento = dtbChamados.Rows(linha).Item(8).ToString()
            Chamado.Label6.Text = Andamento
            ChamadoFinalizado.Label14.Text = Andamento

            Nivel = dtbChamados.Rows(linha).Item(9).ToString()
            ChamadoFinalizado.Label16.Text = Nivel
            Chamado.Label4.Text = Nivel

        Else

            Chamado.Label16.Text = "**********"  'FAZ UMMA LOGICA PRA SE FOR O USUARIO LOGADO APARECE O NOME DELE, SE NAO FOR APARECE ******
            ChamadoFinalizado.Label6.Text = "**************" 'FAZ UMMA LOGICA PRA SE FOR O USUARIO LOGADO APARECE O NOME DELE, SE NAO FOR APARECE ******

            Data = dtbChamados.Rows(linha).Item(5).ToString()
            Chamado.Label2.Text = Data
            ChamadoFinalizado.Label12.Text = Data

            Andamento = dtbChamados.Rows(linha).Item(6).ToString()
            Chamado.Label6.Text = Andamento
            ChamadoFinalizado.Label14.Text = Andamento

            Nivel = dtbChamados.Rows(linha).Item(7).ToString()
            ChamadoFinalizado.Label16.Text = Nivel
            Chamado.Label4.Text = Nivel

        End If


        variaveis.con.Open()
        Dim cmd2 As New SqlCommand("Select Comentar from Manutencao where Cod_Chamado = '" & Codigo & "'", variaveis.con)
        cmd2.ExecuteNonQuery()
        Comentario = cmd2.ExecuteScalar
        variaveis.con.Close()
        ChamadoFinalizado.Label3.Text = Comentario
        If Andamento.ToString = "Em Andamento" Then
            Chamado.Show()
        Else
            ChamadoFinalizado.Show()
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

    Private Sub cbPc_TextChanged(sender As Object, e As EventArgs) Handles cbPc.TextChanged
        filtrarChamados()
    End Sub

    Private Sub cbCargo_TextChanged(sender As Object, e As EventArgs) Handles cbCargo.TextChanged
        filtrarChamados()
    End Sub

    Private Sub filtrarChamados()
        dtbChamados.Clear()
        Dim salaSelecionada = variaveis.retornaItemSelecionado(cbSalas.SelectedItem, "Cod_Ambiente")
        Dim pcSelecionado = variaveis.retornaItemSelecionado(cbPc.SelectedItem, "Cod_Componente")

        Dim queryString = "Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,c.Dia_Hora,c.Andamento,c.Nivel,c.Excluidos from Chamados c,Usuario u, Componente p, Ambiente a where c.Cod_User = u.Cod_User And p.Cod_Componente = c.Cod_Componente And a.Cod_Ambiente = c.Cod_Ambiente And c.Andamento = 'Em Andamento'"
        If variaveis.isAdmin Then
            queryString = "Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,u.Usuario,u.Cargo, c.Dia_Hora,c.Andamento,c.Nivel,c.Excluidos from Chamados c,Usuario u, Componente p, Ambiente a where c.Cod_User = u.Cod_User And p.Cod_Componente = c.Cod_Componente And a.Cod_Ambiente = c.Cod_Ambiente And c.Andamento = 'Em Andamento'"
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
        dtbChamados.Clear()
        adp.Fill(dtbChamados)
        variaveis.con.Close()
    End Sub
End Class