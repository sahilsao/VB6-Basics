Public Class DoWhile1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        i = 0
        ListBox1.Items.Clear()
        Do

            ListBox1.Items.Add(i)
            i = i + 1
        Loop Until i > 10
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        ListBox1.Items.Clear()
        Do
            If (i > 5) Then
                Exit Do
            Else

                ListBox1.Items.Add(i)
                i = i + 1
            End If
        Loop Until i > 100
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        i = 0
        ListBox1.Items.Clear()
        Do

            ListBox1.Items.Add(i)
            i = i + 1
        Loop While (i <= 10)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 0
        ListBox1.Items.Clear()
        Do While i <= 10

            ListBox1.Items.Add(i)
            i = i + 1
        Loop
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer
        i = 0
        ListBox1.Items.Clear()
        Do Until i > 10

            ListBox1.Items.Add(i)
            i = i + 1
        Loop
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class