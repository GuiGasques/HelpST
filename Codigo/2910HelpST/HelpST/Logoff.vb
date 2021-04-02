Public Class Logoff

    Private Sub Logoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
		Dim result As String
		result = MsgBox("Deseja realmente sair ?", vbYesNo)
		If result = DialogResult.Yes Then
			TelaLogin.Show()
		End If
		If variaveis.isAdmin Then
			MenuAdmin.Hide()
			Me.Hide()

		Else
			MenuUser.Hide()
			Me.Hide()

		End If
	End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim result As String
		result = MsgBox("Deseja realmente sair ?", vbYesNo)
		If result = DialogResult.Yes Then
			Application.Exit()
		End If
	End Sub
End Class