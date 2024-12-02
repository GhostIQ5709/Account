
Imports System.Data.SqlClient

Public Class UC_Signup
    Private Sub UC_Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
        lblStatus.Visible = False
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Equals(txtConfirmPassword) Then
            lblStatus.ForeColor = Color.Green
            lblStatus.Text = "Passwords Match!"
            lblStatus.Visible = True
        Else
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Passwords do not match!"
        End If
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If txtPassword.Text.Equals(txtConfirmPassword) Then
            lblStatus.ForeColor = Color.Green
            lblStatus.Text = "Passwords Match!"
            lblStatus.Visible = True
        Else
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Passwords do not match!"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        account.Controls.Clear()
        account.Controls.Add(account.menus)
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim connectionString As String = "Data Source=DELLY;Initial Catalog=designcrib;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand()
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Users (Fullname, Email, Username, Password) VALUES (@fullname, @email, @username, @password)"
            cmd.Parameters.AddWithValue("@fullname", txtFullname.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.ExecuteNonQuery()
            MsgBox("User Account Created Successfully", MsgBoxStyle.Information, "Successful!")
        Catch ex As Exception
            MsgBox("Error during Sign up: " & ex.Message, MsgBoxStyle.Exclamation, "Account Creation Failed!")
        Finally
            conn.Close()
        End Try
    End Sub
End Class
