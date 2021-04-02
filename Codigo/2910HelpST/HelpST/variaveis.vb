Imports System.Data.SqlClient

Module variaveis
    Public dtb As New DataTable
    Public adp As New SqlDataAdapter
	Public con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
	' Public con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=HelpST;Integrated Security=SSPI")
	'Public con As New SqlConnection("server=LENOVO-PC\SQLEXPRESS;Initial Catalog=HelpST;Integrated Security=SSPI")
	Public Login As String
	Public senha As String
    Dim dtbComponente As New DataTable
    Public isAdmin As Boolean
    Public EsconderEnviar As Boolean


    Public Cod_user As Integer
	Public Sub fechaForm()
        con.Open()
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
					MenuAdmin.Show()
				Case "Usuario"
					MenuUser.Show()
			End Select
		End If
        con.Close()
    End Sub
    Public dtbAmbiente As New DataTable
	Public dtbLocal As New DataTable
	Public dtbPC As New DataTable
    Public Sub Ambiente()
        Dim cmd As New SqlCommand("Select * from Ambiente", variaveis.con)
        adp.SelectCommand = cmd
        dtbAmbiente.Clear()
        adp.Fill(dtbLocal)

    End Sub

    Public Sub PC(ByVal codAmbiente)
        Dim cmd As New SqlCommand("Select Pc from Componente where Cod_Ambiente = '" & codAmbiente & "'", variaveis.con)
        adp.SelectCommand = cmd
        dtbAmbiente.Clear()
        adp.Fill(dtbPC)
    End Sub

    Public Function retornaItemSelecionado(ByVal itemSelecionado As DataRowView, ByVal strCampo As String) As Object
        Try
            Return DirectCast(itemSelecionado, DataRowView).Item(strCampo)
        Catch
            Return Nothing
        End Try
    End Function
End Module
