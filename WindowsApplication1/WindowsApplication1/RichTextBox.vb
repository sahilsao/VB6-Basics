Imports System.IO
Public Class RichTextBox
    Private filename As String
    Dim sr As StreamReader

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                filename = OpenFileDialog1.FileName
                sr = New StreamReader(OpenFileDialog1.OpenFile)
                ' RichTextBox1 .Text = sr.Readline  To End()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim sw As StreamWriter
        Try
            SaveFileDialog1.FileName = filename
            SaveFileDialog1.Filter = "Textfiles(*.txt)|*.txt|" & " All Files*.*"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                filename = SaveFileDialog1.FileName
                sw = New StreamWriter(filename)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()

            End If
        End Try
    End Sub

    Private Sub RichTextBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Height = Me.Height
        RichTextBox1.Width = Me.Width
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub SelectForeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Red

    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Blue

    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Green
    End Sub

    Private Sub SelectBackColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaximizedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximizedToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MinimizedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizedToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class