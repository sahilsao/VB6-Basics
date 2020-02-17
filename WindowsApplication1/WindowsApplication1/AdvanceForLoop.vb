Public Class AdvanceForLoop

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i, a As Integer
        Dim arr As Integer() = {10, 20, 30, 40, 50}
        ListBox1.Items.Clear()
        For Each i In arr
            ListBox1.Items.Add("  " & i)
        Next i
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Button2.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class