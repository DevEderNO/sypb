Imports SyPB.loginDAO
Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = Nothing And PasswordTextBox.Text = Nothing Then
            MsgBox("Usuario e Senha não informados")
        ElseIf UsernameTextBox.Text = Nothing Then
            MsgBox("Usuario não informado")
        ElseIf PasswordTextBox.Text = Nothing Then
            MsgBox("Senha não informada")
        Else
            Dim login As New loginTO
            Dim dao As New loginDAO
            login.lg_usuario = UsernameTextBox.Text
            login.lg_senha = PasswordTextBox.Text
            dao.buscar(login)
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Cadastro_Login.Show()
    End Sub
End Class
