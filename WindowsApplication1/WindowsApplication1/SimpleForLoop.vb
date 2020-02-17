Public Class SimpleForLoop
    Dim i As Integer
    Dim n As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For i = 0 To 10
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        n = InputBox("Enter The Limit... ", "Response", 0)
        ListBox1.Items.Clear()
        For i = 0 To n
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        n = InputBox("Enter the Limit... ", "Response", 0)
        ListBox1.Items.Clear()
        For i = 0 To n Step 2
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        n = InputBox("Enter the Limit... ", "Response", 0)
        ListBox1.Items.Clear()
        For i = 1 To n Step 2
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim fact As Integer
        n = InputBox("Enter the Limit... ", "Response", 0)
        fact = 1
        For i = 1 To n
            fact = fact * i
        Next
        MessageBox.Show("The Factorial of " & n & " is = " & fact, " Result ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
        Button1.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class