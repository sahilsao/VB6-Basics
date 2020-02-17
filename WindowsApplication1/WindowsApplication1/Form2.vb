Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        For i = 0 To 10
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim n As Integer
        Dim i As Integer
        n = InputBox("Enter Limit :", "Reponse", 0)
        For i = 0 To n
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        Dim n As Integer = InputBox("Enter Limit :", "Reponse", 0)

        For i = 0 To n Step 2
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        Dim n As Integer = InputBox("Enter Limit :", "Reponse", 0)

        For i = 1 To n Step 2
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        Dim fact As Integer = 1
        Dim i As Integer
        Dim n As Integer = InputBox("Enter Limit :", "Response", 0)
        For i = 0 To n
            fact = fact * i
        Next
        ListBox1.Items.Add(fact)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        Dim j As Integer
        For i = 0 To 3
            For j = 0 To 10
                ListBox1.Items.Add(i & " * " & j & " = " & (i * j))
            Next
            ListBox1.Items.Add("----------------------------------------")
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        Dim n As Integer = InputBox("Enter your choice :", "Reponse", 0)
        For i = 0 To 10
            ListBox1.Items.Add(n & " *" & i & " = " & (n * i))
        Next
    End Sub
End Class