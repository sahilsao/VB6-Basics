Public Class NestedForLoop
    Dim i As Integer
    Dim n As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st As String
        Dim j As Integer
        ListBox1.Items.Clear()
        For i = 1 To 3
            For j = 1 To 10
                st = i & " * " & j & " = " & (i * j)
                ListBox1.Items.Add(st)
            Next j
            ListBox1.Items.Add("----------------")
        Next i
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim st As String
        ListBox1.Items.Clear()
        n = InputBox("Enter Any Integer No... ", " Response ", 0)
        For i = 1 To 10
            st = n & " * " & i & " = " & (n * i)
            ListBox1.Items.Add(st)
            ListBox1.Items.Add("    ")
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Button1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class