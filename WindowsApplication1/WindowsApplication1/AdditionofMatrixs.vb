Public Class AdditionofMatrixs

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim arr1(3, 3) As Integer
        Dim arr2(3, 3), arr3(3, 3) As Integer
        Dim i, j As Integer
        For i = 0 To 2
            For j = 0 To 2
                arr1(i, j) = InputBox("Enter Elements of Matrix A :", "Response", 0)

            Next j
        Next i
        For i = 0 To 2
            For j = 0 To 2
                arr2(i, j) = InputBox("Enter Elements of Matrix B:", "Response", 0)

            Next j
        Next i
        MessageBox.Show("The OutPut Are Print Only in Console Application ")
        Console.WriteLine("The Given Matrix A is :")
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(arr1(i, j) & "    ")

            Next

            Console.WriteLine()

        Next


        Console.WriteLine("The Given Matrix B is :")
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(arr2(i, j) & "    ")
            Next
            Console.WriteLine()
        Next


        Console.WriteLine("The Given Matrix C is :")
        For i = 0 To 2
            For j = 0 To 2

                arr3(i, j) = arr1(i, j) + arr2(i, j)
                Console.Write(arr3(i, j) & "     ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class