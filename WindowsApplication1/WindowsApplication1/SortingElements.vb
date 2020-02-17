Public Class SortingElements

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arr(4) As Integer
        Dim j, temp As Integer
        Dim i As Integer
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        'n = InputBox("Enter Limit", "Response", 0)
        ListBox1.Items.Add("Items Before Sorting... ")
        For i = 0 To 4
            arr(i) = InputBox("Enter Any Integer No : ", "Response", 0)
            ListBox1.Items.Add(arr(i))

        Next
        For i = 0 To 4
            For j = 0 To 4
                If (arr(i) < arr(j)) Then
                    temp = arr(i)
                    arr(i) = arr(j)
                    arr(j) = temp

                End If
            Next
        Next
        ListBox2.Items.Add("Items After Sorting ")
        For i = 0 To 4
            ListBox2.Items.Add(arr(i))

        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class