Public Class SelectCase2

    Dim area, ract, tri, sqr As Single
    Dim r, length, breadth, height, side As Integer

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim i As Integer
        i = Val(TextBox1.Text)
        Select Case i
            Case 1
                r = InputBox("Enter Radius... ", " Response", 0)
                area = 3.142 * r * r
                MessageBox.Show("The Area of a Circle is = " & area, " Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                length = InputBox("Enter The Value of Lenght... ", "Response", 0)
                breadth = InputBox("Enter The Value of Breadth... ", "Response", 0)
                ract = length * breadth
                MessageBox.Show("The Area of a Rectangle is = " & ract, " Result ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case 3
                height = InputBox("Enter The Value of height... ", " Response", 0)
                side = InputBox("Enter The Value of Sides... ", " Response", 0)
                tri = 0.5 * height * side
                MessageBox.Show("The Area of a Tringle is = " & tri, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                side = InputBox("Enter The Value of Side... ", "Response", 0)
                sqr = side * side
                MessageBox.Show("The Square Root of " & side & " = " & sqr, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                Me.Close()
            Case Else
                MessageBox.Show(" Involid Choice ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "5" Then
            Button7.Text = " OK "
        Else
            Button7.Text = "Show"
        End If
    End Sub
End Class