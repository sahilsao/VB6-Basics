Public Class AccessConectivity1

    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub AccessConectivity1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\VB Notes\Excel.accdb"
        cn.Open()
        If rs.State Then
            rs.Close()
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If textBox1.Text = "" Or textBox2.Text = "" Or textBox3.Text = "" Or textBox4.Text = "" Then
            MessageBox.Show("Please Fill All Information...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call clear()
        Else
            cn.Execute("Insert into empinfo values (" & textBox1.Text & ",'" & textBox2.Text & "','" & textBox3.Text & "'," & textBox4.Text & ")")
            MessageBox.Show("Record Save Successfully...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
        End If
    End Sub
    Sub clear()
        textBox1.Clear()
        textBox2.Clear()
        textBox3.Clear()
        textBox4.Clear()
        textBox1.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        If rs.State Then
            rs.Close()
        End If
        Try

        
        a = InputBox("Enter EmpID... ", "Response", 0)
        rs.Open("Select * From empinfo where empid = " & a & "", cn, 1, 2)
        If rs.RecordCount > 0 Then
            textBox1.Text = rs.Fields(0).Value
            textBox2.Text = rs.Fields(1).Value
            textBox3.Text = rs.Fields(2).Value
            textBox4.Text = rs.Fields(3).Value
        Else
            MessageBox.Show("Record Not Found... ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As String
        a = MessageBox.Show("Do You Want To Modify This Record...", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            cn.Execute("Update empinfo set empname = '" & textBox2.Text & "',dept = '" & textBox3.Text & "', salary = " & textBox4.Text & " where empid = " & textBox1.Text & " ")
            MessageBox.Show("Record Modify Successfully... ", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String
        a = MessageBox.Show("Do You Want To Delete This Record... ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            cn.Execute("Delete from empinfo where empid = " & textBox1.Text & " ")
            MessageBox.Show("Record Deleted Successfully...", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
