Imports SyPB.loginDAO
Public Class Cadastro_Login
    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        txtUsuario.MaxLength = 45
    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged
        txtSenha.MaxLength = 45
    End Sub

    Private Sub txtConfSenha_TextChanged(sender As Object, e As EventArgs) Handles txtConfSenha.TextChanged
        txtConfSenha.MaxLength = 45
    End Sub

    Private Sub bt_cadastrar_Click(sender As Object, e As EventArgs) Handles bt_cadastrar.Click
        Dim login As loginTO = New loginTO()
        Dim dao As New loginDAO
        login.lg_usuario = txtUsuario.Text
        login.lg_senha = txtSenha.Text
        login.lg_tipo = comboTipo.SelectedIndex
        dao.incluir(login)
    End Sub
End Class