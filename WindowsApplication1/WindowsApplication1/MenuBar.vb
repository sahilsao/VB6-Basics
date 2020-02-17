Public Class MenuBar

    Private Sub MenuBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
        RedToolStripMenuItem.Checked = False
        BlueToolStripMenuItem.Checked = True
        GreenToolStripMenuItem.Checked = True

        RedToolStripMenuItem.Checked = True
        BlueToolStripMenuItem.Checked = False
        GreenToolStripMenuItem.Checked = False
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.Blue
        RedToolStripMenuItem.Checked = True
        BlueToolStripMenuItem.Checked = False
        GreenToolStripMenuItem.Checked = True

        RedToolStripMenuItem.Checked = False
        BlueToolStripMenuItem.Checked = True
        GreenToolStripMenuItem.Checked = False

    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Green
        RedToolStripMenuItem.Checked = True
        BlueToolStripMenuItem.Checked = True
        GreenToolStripMenuItem.Checked = False

        RedToolStripMenuItem.Checked = False
        BlueToolStripMenuItem.Checked = False
        GreenToolStripMenuItem.Checked = True
    End Sub

    Private Sub RedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem1.Click
        Me.BackColor = Color.Red

    End Sub

    Private Sub BlueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem1.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem1.Click
        Me.BackColor = Color.Green
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

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim fpath As String
        OpenFileDialog1.Title = "Open:Excel_Tech"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()
        fpath = OpenFileDialog1.FileName
        MessageBox.Show("Selected File is : " & fpath, " Msg ", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Label1.Font = FontDialog1.Font

    End Sub

    Private Sub SelectBackColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectBackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub SelectForeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color

    End Sub
End Class