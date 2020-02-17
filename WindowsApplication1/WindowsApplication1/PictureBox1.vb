Public Class PictureBox1

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PicBox3.Image = Image.FromFile("C:\VB Notes\Images\LoginForm14.jpg")
    End Sub
End Class