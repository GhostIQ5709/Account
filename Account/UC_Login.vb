Imports System.Data.SqlClient

Public Class UC_Login
    Private Sub UC_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        account.Controls.Clear()
        account.Controls.Add(account.menus)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Data Source=DELLY;Initial Catalog=designcrib;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Users Where Username = @username AND Password = @password"
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MsgBox("User logged in successfully!", MsgBoxStyle.Information, "Successful!")
                ' Code to open the main application goes here
                Me.Hide()
                account.Hide()
                Dim vpn As New vpn()
                vpn.ShowDialog()
            Else
                MsgBox("User Account Does not Exist. Create one", MsgBoxStyle.Information, "Log in Failed")
            End If
        Catch ex As Exception
            MsgBox("Error during log in: " & ex.Message, MsgBoxStyle.Exclamation, "Account Creation Failed")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
