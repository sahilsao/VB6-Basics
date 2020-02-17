Public Class Two_Dimantional_Array

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arr(3, 3) As Double
        Dim i, j As Integer
        For i = 0 To 2
            For j = 0 To 2
                arr(i, j) = InputBox("Enter Elements of Matrix", "Response", 0)

            Next j
        Next i
        MessageBox.Show("The OutPut Are Print Only in Console Application ")
        Console.WriteLine("The Given Matrix is :")
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(arr(i, j) & "  ")
            Next

            Console.WriteLine()
        Next

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class