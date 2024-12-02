Public Class account
    Public menus As MenuStrip
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Controls.Clear()
        Dim login As New UC_Login()
        login.Top = MenuStrip1.Height
        login.Dock = DockStyle.Fill
        Me.Controls.Add(login)
        Controls.Add(menus)
    End Sub

    Private Sub SignupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignupToolStripMenuItem.Click
        Controls.Clear()
        Dim signup As New UC_Signup()
        signup.Top = MenuStrip1.Height
        signup.Dock = DockStyle.Fill
        Me.Controls.Add(signup)
        Controls.Add(menus)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menus = MenuStrip1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActionToolStripMenuItem.Click

    End Sub
End Class
