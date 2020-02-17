Public Class ListBox

    Private Sub ListBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add(" Keyboard ")
            .Add(" Moniter ")
            .Add(" Mouse ")
            .Add(" RAM ")

        End With
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter any item... ")

            TextBox1.Focus()
        Else
            ListBox3.Items.Add(TextBox1.Text)
            TextBox1.Text = ""


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        Label5.Text = ""
        Label6.Text = ""
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        'i = ListBox3.SelectedIndex
        If ListBox3.SelectedIndex < 0 Then
            MessageBox.Show("No Items to Deleted...")
        Else
            ListBox3.Items.RemoveAt(ListBox3.SelectedIndex)

            ListBox3.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label5.Text = "Your Choice is :" & ListBox1.Text

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Label6.Text = "Your Choice is :" & ListBox2.Text
    End Sub
End Class