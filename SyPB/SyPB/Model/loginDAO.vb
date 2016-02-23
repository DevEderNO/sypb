Imports MySql.Data.MySqlClient
Public Class loginDAO
    Sub incluir(ByVal login As loginTO)
        Dim _conexaoMySQL As String = "server=localhost;user id=root;password=admin;database=sipb"
        Dim con As MySqlConnection = New MySqlConnection(_conexaoMySQL)
        Dim cmd As MySqlCommand
        Try
            Dim cmdSQL As String = "INSERT INTO login (usuario,senha,tipo) VALUES (@Usuario,@Senha,@Tipo)"
            cmd = New MySqlCommand(cmdSQL, con)
            cmd.Parameters.Add("@Usuario", MySqlDbType.VarChar, 45)
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar, 45)
            cmd.Parameters.Add("@Tipo", MySqlDbType.Int16, 11)

            cmd.Parameters("@Usuario").Value = Login.lg_usuario
            cmd.Parameters("@Senha").Value = Login.lg_senha
            cmd.Parameters("@Tipo").Value = login.lg_tipo

            con.Open()
            Dim linhasAfetadas As Integer = cmd.ExecuteNonQuery()
            If (linhasAfetadas > 0) Then
                MsgBox("Cadastro efetuado com sucesso")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Sub buscar(ByVal login As loginTO)
        Dim _conexaoMySQL As String = "server=localhost;user id=root;password=admin;database=sipb"
        Dim con As MySqlConnection = New MySqlConnection(_conexaoMySQL)
        Dim cmd As MySqlCommand
        Try
            Dim cmdSQL As String = "SELECT * FROM login WHERE usuario = @User AND senha = @Pas "
            cmd = New MySqlCommand(cmdSQL, con)
            con.Open()
            cmd.Parameters.AddWithValue("@User", login.lg_usuario)
            cmd.Parameters.AddWithValue("@Pas", login.lg_senha)


            Dim linhasAfetadas As Integer = cmd.ExecuteNonQuery()
            If (linhasAfetadas > 0) Then
                MsgBox("Cadastro efetuado com sucesso")
            End If
            MsgBox(cmdSQL)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

End Class
