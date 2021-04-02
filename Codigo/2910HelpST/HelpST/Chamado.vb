Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class Chamado
    Public Cod_Chamado As Integer
    Public dtb As New DataTable
    Public adp As New SqlDataAdapter
    Private Sub Chamado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Login As String = TelaLogin.txtLogin.Text
        Dim Senha As String = TelaLogin.txtSenha.Text

        If Not variaveis.isAdmin Then
            btnResponder.Visible = False
        End If


        variaveis.con.Open()

        Dim sql As String
        sql = "select login_user, Hierarquia  from usuario where login_user = @user and senha = @senha"
        Dim cmd As New SqlCommand(sql, variaveis.con)

        cmd.Parameters.AddWithValue("@user", Login)
        cmd.Parameters.AddWithValue("@senha", Senha)
        adp.SelectCommand = cmd
        dtb.Clear()
        adp.Fill(dtb)
        If (dtb.Rows.Count > 0) Then
            Select Case dtb.Rows(0).Item(1).ToString()
                Case "Administrador"

                Case "Usuario"
                    btnResponder.Hide()
            End Select
            variaveis.con.Close()
        End If
        variaveis.con.Close()
    End Sub

    Private Sub btnResponder_Click(sender As Object, e As EventArgs) Handles btnResponder.Click
        ResponderChamado.Cod_Chamado = Cod_Chamado
        ResponderChamado.ShowDialog()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        variaveis.con.Open()
        Dim cmd As New SqlCommand("Select Imagem from Chamados where Cod_Chamado = '" & Cod_Chamado & "'", variaveis.con)
        cmd.ExecuteNonQuery()
        Dim imagePath = cmd.ExecuteScalar
        variaveis.con.Close()
        If Not imagePath = "" Then
            carrega.Image = Image.FromFile(imagePath)
        Else
            MsgBox("Chamado não possui imagem")
        End If
    End Sub

End Class