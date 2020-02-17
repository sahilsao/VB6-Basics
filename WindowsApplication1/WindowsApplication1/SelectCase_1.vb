Public Class SelectCase1

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim msg As String
        n = InputBox("Enter Any Integer Number... ", "Respose", 0)
        Select Case n
            Case 0
                msg = "Good Morning"
            Case 1
                msg = "Good After Noon"
            Case 2
                msg = "Good Evning"
            Case 3
                msg = "Good Night"
            Case Else
                MessageBox.Show("Involid Choice... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
        End Select


        MessageBox.Show(msg, "MsgBox", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class