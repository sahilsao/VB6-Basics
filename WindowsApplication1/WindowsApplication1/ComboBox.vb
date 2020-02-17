Public Class ComboBox

    Private Sub ComboBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With ComboBox2.Items
            .Add(" Keyboard ")
            .Add(" Moniter ")
            .Add(" Mouse ")
            .Add(" RAM ")

        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Text = ""
        Label5.Text = ""

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            MessageBox.Show(" Enter any item... ")

            TextBox1.Focus()
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
            Label5.Text = ComboBox1.Items.Count & " Item(s) Added..."

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        i = ComboBox1.SelectedIndex
        If i < 0 Then
            MessageBox.Show(" No Items to Deleted...")
        Else
            ComboBox1.Items.RemoveAt(i)
            Label5.Text = ComboBox1.Items.Count & " Item(S) Added..."
            ComboBox1.Text = ""
        End If
    End Sub
End Class