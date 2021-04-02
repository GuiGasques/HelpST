Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Imports System.IO

Public Class NovoChamado
    Dim caminho As String
    Dim dtbAmbiente As New DataTable
    Dim dtbComponente As New DataTable
    Dim dtb As New DataTable
    Dim codigo As Integer = variaveis.Cod_user
    Public codigoSala As String
    Public codigoComponente As String
    Public Cod_Chamado As Integer
    Dim dtbLocal As New DataTable
    Dim dtbChamados As New DataTable
    Public adp As New SqlDataAdapter
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If Cod_Chamado = 0 Then
            InserirChamado()
        Else
            AlterarChamado()
        End If
    End Sub

    Private Sub AlterarChamado()
        variaveis.con.Open()
        Dim Data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
        Dim imagePath = SalvarImagem()
        Dim cmd As New SqlCommand("UPDATE Chamados set Titulo ='" & txtTitulo.Text & "', Descricao = '" & txtDescriçao.Text & "', Imagem = '" & imagePath & "', Dia_Hora = '" & Data & "' where Cod_Chamado = '" & Cod_Chamado & "'", variaveis.con)
        cmd.ExecuteNonQuery()
        variaveis.con.Close()
        MsgBox("CHAMADO ALTERADO")
        Me.Close()
        MeusChamados.AtualizaGrid()
        MeusChamados.Show()
    End Sub

    Private Sub InserirChamado()
        variaveis.con.Open()
        Dim cmd1 As New SqlCommand("Select Cod_Ambiente from Ambiente where Sala = '" & cbSalas.Text & "'", variaveis.con)
        cmd1.ExecuteNonQuery()
        codigoSala = cmd1.ExecuteScalar

        Dim cmd2 As New SqlCommand("Select Cod_Componente from Componente where Cod_Ambiente =  '" & codigoSala.ToString & "' and Pc = '" & cbPc.Text & "'", variaveis.con)
        cmd2.ExecuteNonQuery()
        codigoComponente = cmd2.ExecuteScalar
        'If DialogResult = Windows.Forms.DialogResult.OK Then
        Dim Data As String
        Data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
        Dim imagePath = SalvarImagem()
        Dim cmd As New SqlCommand("INSERT INTO Chamados (Titulo,Descricao,Andamento,Dia_Hora,Imagem,Cod_User,Cod_Ambiente,Cod_Componente,Excluidos,Nivel) values ('" & txtTitulo.Text & "','" & txtDescriçao.Text & "','Em Andamento','" & Data & "','" & imagePath & "'," & TelaLogin.Cod_user & ",'" & codigoSala & "','" & codigoComponente & "','n','Indefinido')", variaveis.con)
        cmd.ExecuteNonQuery()
        variaveis.con.Close()
        MsgBox("CHAMADO ENVIADO")
        Me.Close()
        MeusChamados.Show()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        OpenFileDialog1.ShowDialog()
        caminho = OpenFileDialog1.FileName
        If Not caminho Is Nothing Then
            PictureBox1.Load(caminho)
        End If
    End Sub

    Private Sub NovoChamado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroLabel5.Text = variaveis.Login

        variaveis.con.Open()

        Dim cmd2 As New SqlCommand("Select * from Ambiente", variaveis.con)
        Dim adp2 As New SqlDataAdapter()
        adp2.SelectCommand = cmd2
        dtbLocal.Clear()
        adp2.Fill(dtbLocal)

        variaveis.Ambiente()

        cbSalas.DataSource = dtbLocal
        cbSalas.DisplayMember = "Sala"

        Dim cmdUp As New SqlCommand("Select * from Chamados", variaveis.con)
        Dim adpUp As New SqlDataAdapter()
        adpUp.SelectCommand = cmdUp
        dtbChamados.Clear()
        adp2.Fill(dtbChamados)

        variaveis.con.Close()

        If Cod_Chamado = 0 Then
            btnEnviar.Text = "Enviar"
        Else
            btnEnviar.Text = "Alterar"
            cbSalas.Text = codigoSala
            cbPc.Text = codigoComponente
            cbSalas.Enabled = False
            cbPc.Enabled = False
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
        Dim cmd1 As New SqlCommand("Select Pc from Componente where Cod_Ambiente = '" & codAmbiente & "'", variaveis.con)
        adp.SelectCommand = cmd1
        dtbComponente.Clear()
        adp.Fill(dtbPC)
        cbPc.DataSource = dtbPC
        cbPc.DisplayMember = "Pc"
        variaveis.con.Close()
    End Sub
    Public Sub AtualizaGrid()
        Dim cmd As New SqlCommand("Select * from Ambiente", variaveis.con)
        adp.SelectCommand = cmd
        dtbChamados.Clear()
        adp.Fill(dtbChamados)

    End Sub

    Private Function SalvarImagem() As String
        Dim spath As String
        Dim imagePath As String = Nothing
        spath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        spath = New Uri(spath).LocalPath
        If (Not System.IO.Directory.Exists(Path.Combine(spath, "ImagensChamado"))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, "ImagensChamado"))
        End If
        If Not PictureBox1.Image Is Nothing Then
            imagePath = Path.Combine(spath, "ImagensChamado", "img_" & DateTime.Now.ToString("yyyymmddhhMMss") & ".jpg")
            PictureBox1.Image.Save(imagePath)
        End If

        Return imagePath
    End Function
End Class