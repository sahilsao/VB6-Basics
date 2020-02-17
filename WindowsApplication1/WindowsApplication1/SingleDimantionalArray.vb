Public Class SingleDimantionalArray
    Dim i As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim arr(4) As Integer
        arr(0) = 11
        arr(1) = 12
        arr(2) = 13
        arr(3) = 14
        arr(4) = 15
        For Each i In arr
            ListBox1.Items.Add(i)
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim arr(4) As String
        ListBox1.Items.Clear()
        For i = 0 To 4
            arr(i) = InputBox("Enter Array Elements are :")
        Next
            ListBox1.Items.Add("Array Elements are : ")
            For Each i In arr
                ListBox1.Items.Add(i)
            Next

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class