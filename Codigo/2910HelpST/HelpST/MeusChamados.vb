Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class MeusChamados
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
	Dim dtbChamadosAbertos As New DataTable
	Dim Codigo As Integer
    Dim data As String

    Private Sub MeusChamados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label2.Text = variaveis.Login
		AtualizaGrid()
        gridChamadosAbertos.DataSource = dtbChamadosAbertos

    End Sub
    Public Sub AtualizaGrid()
        variaveis.con.Open()
        Dim cmd As New SqlCommand(" Select c.Cod_Chamado,c.Titulo,c.Descricao,p.Pc,a.Sala,u.Usuario,c.Dia_Hora,c.Andamento,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente and c.Cod_User = " & TelaLogin.Cod_user & " and c.Excluidos = 'n'", variaveis.con)
        Dim adp As New SqlDataAdapter()
        adp.SelectCommand = cmd
        dtbChamadosAbertos.Clear()
        adp.Fill(dtbChamadosAbertos)
        variaveis.con.Close()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim linha = gridChamadosAbertos.CurrentRow.Index
        NovoChamado.Cod_Chamado = Convert.ToInt32(dtbChamadosAbertos.Rows(linha).Item(0).ToString())
        NovoChamado.codigoSala = dtbChamadosAbertos.Rows(linha).Item(4).ToString()
        NovoChamado.codigoComponente = dtbChamadosAbertos.Rows(linha).Item(3).ToString()
        NovoChamado.ShowDialog()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		dtbChamadosAbertos.Rows.RemoveAt(gridChamadosAbertos.CurrentRow.Index)
		variaveis.con.Open()
		Dim cmd1 As New SqlCommand("UPDATE Chamados set Excluidos = 'Excluido' where Cod_Chamado = " & Codigo, variaveis.con)
		cmd1.ExecuteNonQuery()
		variaveis.con.Close()
		AtualizaGrid()
	End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        variaveis.fechaForm()
        Me.Close()

    End Sub

	Public Sub gridChamadosAbertos_Click(sender As Object, e As EventArgs) Handles gridChamadosAbertos.Click
		Codigo = dtbChamadosAbertos.Rows(gridChamadosAbertos.CurrentRow.Index).Item("Cod_Chamado")
		NovoChamado.txtTitulo.Text = dtbChamadosAbertos.Rows(gridChamadosAbertos.CurrentRow.Index).Item("Titulo")
		NovoChamado.txtDescriçao.Text = dtbChamadosAbertos.Rows(gridChamadosAbertos.CurrentRow.Index).Item("Descricao")
		NovoChamado.MetroDateTime1.Text = dtbChamadosAbertos.Rows(gridChamadosAbertos.CurrentRow.Index).Item("Dia_Hora")
        NovoChamado.cbSalas.Text = dtbChamadosAbertos.Rows(gridChamadosAbertos.CurrentRow.Index).Item("Sala")
        NovoChamado.cbPc.Text = dtbChamadosAbertos.Rows(gridChamadosAbertos.CurrentRow.Index).Item("Pc")
    End Sub

    Private Sub gridChamadosAbertos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridChamadosAbertos.CellMouseDoubleClick
        Dim Titulo As String
        Dim linha As Integer
        Dim Descriçao As String
        Dim Usuario As String
        Dim Sala As String
        Dim Computador As String
        Dim Data As String
        Dim Andamento As String
        Dim Nivel As String


        linha = gridChamadosAbertos.CurrentRow.Index

        Codigo = Convert.ToInt32(dtbChamadosAbertos.Rows(linha).Item(0).ToString())
        Titulo = dtbChamadosAbertos.Rows(linha).Item(1).ToString()
        Chamado.Cod_Chamado = Codigo
        ChamadoFinalizado.Cod_Chamado = Codigo
        Chamado.Label3.Text = Titulo
        ChamadoFinalizado.Label2.Text = Titulo

        Sala = dtbChamadosAbertos.Rows(linha).Item(4).ToString()
        Chamado.Label9.Text = Sala
        ChamadoFinalizado.Label8.Text = Sala

        Computador = dtbChamadosAbertos.Rows(linha).Item(3).ToString()
        Chamado.Label11.Text = Computador
        ChamadoFinalizado.Label10.Text = Computador

        Descriçao = dtbChamadosAbertos.Rows(linha).Item(2).ToString()
        Chamado.Label14.Text = Descriçao
        ChamadoFinalizado.rtTexto.Text = Descriçao

        Usuario = dtbChamadosAbertos.Rows(linha).Item(5).ToString()
        Chamado.Label16.Text = Usuario
        ChamadoFinalizado.Label6.Text = Usuario

        Data = dtbChamadosAbertos.Rows(linha).Item(6).ToString()
        Chamado.Label2.Text = Data
        ChamadoFinalizado.Label12.Text = Data

        Andamento = dtbChamadosAbertos.Rows(linha).Item(7).ToString()
        Chamado.Label6.Text = Andamento
        ChamadoFinalizado.Label14.Text = Andamento

        Nivel = dtbChamadosAbertos.Rows(linha).Item(8).ToString()
        ChamadoFinalizado.Label16.Text = Nivel
        Chamado.Label4.Text = Nivel

        'variaveis.con.Open()

        'Dim cmd2 As New SqlCommand("Select Comentar from Manutencao where Cod_Chamado = '" & Codigo & "'", variaveis.con)
        'cmd2.ExecuteNonQuery()
        'Comentario = cmd2.ExecuteScalar
        'variaveis.con.Close()
        'ChamadoFinalizado.Label3.Text = Comentario
        'If Andamento.ToString = "Em Andamento" Then
        '    Chamado.Show()
        'Else
        '    ChamadoFinalizado.Show()
        'End If


    End Sub
End Class