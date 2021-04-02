Imports System.Data.SqlClient

Public Class ChamadoFinalizado
    Public Cod_Chamado As Integer
    Private Sub ChamadoFinalizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        variaveis.con.Open()
        Dim cmd As New SqlCommand("Select Imagem from Chamados where Cod_Chamado = '" & Cod_Chamado & "'", variaveis.con)
        cmd.ExecuteNonQuery()
        Dim imagePath = cmd.ExecuteScalar
        variaveis.con.Close()
        If Not imagePath = "" Then
            PictureBox1.Image = Image.FromFile(imagePath)
        Else
            MsgBox("Chamado não possui imagem")
        End If
    End Sub
End Class