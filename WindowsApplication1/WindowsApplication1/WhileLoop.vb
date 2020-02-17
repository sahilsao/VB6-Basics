Public Class WhileLoop

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        i = 0
        While (i <= 10)
            If (i > 5) Then
                Exit While
            Else
                ListBox1.Items.Add(i)
                i = i + 1
            End If
        End While
    End Sub
End Class