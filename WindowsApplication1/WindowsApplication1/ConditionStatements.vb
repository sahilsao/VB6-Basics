Public Class ConditionStatements

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim age As Integer
        age = InputBox("Enter Your Age... ", "Verify", 0)
        If age >= 18 Then
            MessageBox.Show("You are Eligible to Vote... ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim age As Integer
        Try

        
        age = InputBox("Enter Your Age... ", "Verify", 0)
            If age >= 18 Or age < 100 Then
                MessageBox.Show("You are Eligible to Vote... ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("You are Not Eligible to Vote... ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim n As Integer
        n = InputBox("Enter Any Integer Number... ", "Response", 0)
        If (n Mod 2) = 0 Then
            MessageBox.Show("The Given Number " & n & " is Even ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The Given Number " & n & " is Odd ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim age As Integer
        Dim n As Integer
        age = InputBox("Enter Your Age... ", "Verify", 0)
        If (age >= 18 And age < 100) Then
            n = InputBox("Enter Your CitizenShip Code,(1-China,2-India,3-Other)...", "Verifying", 0)
            If (n = 2) Then
                MessageBox.Show("You are Eligible to Vote... ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Check Your CitizenShip Code... ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            MessageBox.Show("You are Not Eligible to Vote... ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim n As Integer
        Try

        
            n = InputBox("Enter Any Integer Number... ", "Respose", 0)
            If n < 10 Then
                MessageBox.Show("Single Digit Number.. ", "Result")
            ElseIf (n >= 10 And n < 100) Then
                MessageBox.Show("Two Digit Number... ", "Result")
            ElseIf (n >= 100 And n < 1000) Then
                MessageBox.Show("Three Digit Number... ", "Result")
            ElseIf (n >= 1000 And n < 10000) Then
                MessageBox.Show("Four Digit Number... ", "Result")
            Else
                MessageBox.Show("More Than Four Digit Number... ", "Result")


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class