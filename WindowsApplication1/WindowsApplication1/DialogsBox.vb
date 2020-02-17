Public Class DialogsBox

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fpath As String
        OpenFileDialog1.Title = "Open:ExcelTechnologies"
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.ShowDialog()
        fpath = OpenFileDialog1.FileName
        MessageBox.Show("Seleceted File is :" & fpath, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FontDialog1.ShowDialog()
        Label1.Font = FontDialog1.Font
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PrintDialog1.ShowDialog()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FolderBrowserDialog1.ShowDialog()

    End Sub
End Class