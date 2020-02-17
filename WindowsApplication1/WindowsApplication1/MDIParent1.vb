Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim a As New Calculater
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim a As New ConditionStatements
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim a As New DialogsBox
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim a As New LinkLable
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim a As New ProgressBar
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub TimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As New Timer
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SimpleForLoopToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleForLoopToolStripMenuItem1.Click
        Dim a As New SimpleForLoop
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub NestedForLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NestedForLoopToolStripMenuItem.Click
        Dim a As New NestedForLoop
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub AdvanceForLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanceForLoopToolStripMenuItem.Click
        Dim a As New AdvanceForLoop
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub SelectCase1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectCase1ToolStripMenuItem1.Click
        Dim a As New SelectCase1
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SelectCase2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectCase2ToolStripMenuItem1.Click
        Dim a As New SelectCase2
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub WhileLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhileLoopToolStripMenuItem.Click
        Dim a As New WhileLoop
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub DoWhileLoopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoWhileLoopToolStripMenuItem.Click
        Dim a As New DoWhile1
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SingleDimantionalArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingleDimantionalArrayToolStripMenuItem.Click
        Dim a As New SingleDimantionalArray
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub SortingElementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortingElementsToolStripMenuItem.Click
        Dim a As New SortingElements
        a.MdiParent = Me
        a.Show()

    End Sub

    Private Sub TwoDimantionalArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwoDimantionalArrayToolStripMenuItem.Click
        Dim a As New Two_Dimantional_Array
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub AdditionOfMatrixsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdditionOfMatrixsToolStripMenuItem.Click
        Dim a As New AdditionofMatrixs
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub PictureBox1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1ToolStripMenuItem.Click
        Dim a As New PictureBox1
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub PictureBox2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2ToolStripMenuItem.Click
        Dim a As New PicBoxWithTimer
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub AccessConnectivity1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessConnectivity1ToolStripMenuItem.Click
        Dim a As New AccessConectivity1
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub AccessConnectivity2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessConnectivity2ToolStripMenuItem.Click
        Dim a As New AccessConectivity2
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub MenuBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBarToolStripMenuItem.Click
        Dim a As New MenuBar
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub RichTextBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBoxToolStripMenuItem.Click
        Dim a As New RichTextBox
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub TimerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerToolStripMenuItem.Click
        Dim A As New Timer
        A.MdiParent = Me
        A.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim A As New ComboBox
        A.MdiParent = Me
        A.Show()
    End Sub

    Private Sub AccessConnectivity3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessConnectivity3ToolStripMenuItem.Click
        Dim a As New AccessConectivity3
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub AccessConnectivity4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessConnectivity4ToolStripMenuItem.Click
        Dim a As New AccessConectivity4
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim a As New ListBox
        a.MdiParent = Me
        a.Show()
    End Sub
End Class
