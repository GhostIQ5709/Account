Public Class vpn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1 As New Form1()
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class