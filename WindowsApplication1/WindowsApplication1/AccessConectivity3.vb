Public Class AccessConectivity3
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub AccessConectivity3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\VB Notes\Excel.accdb"
            cn.Open()
            If rs.State Then
                rs.Close()
            End If
            Button2.Enabled = False
            Button3.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If textBox1.Text = "" Or textBox2.Text = "" Or TextBox6.Text = "" Then
                MessageBox.Show("Please Fill EmpId , EmpName & Salary is Campalsary...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call clear()
            Else
                cn.Execute("Insert into empinfo values (" & textBox1.Text & ",'" & textBox2.Text & "','" & textBox3.Text & "'," & TextBox6.Text & ")")
                cn.Execute("Insert into empDetails values (" & textBox1.Text & ",'" & textBox4.Text & "','" & TextBox5.Text & "')")
                'cn.Execute("Insert into a.EmpId, a.empName, a.Dept, b.EmailId, b.Contactno, a.Salary From empinfo a, empdetails b where a.empid = b.empid and a.empid = " & a & ",a.empname = '" & textBox2.Text & "',a.dept = '" & textBox3.Text & "', b.empid = " & a & ",b.emailid = '" & textBox4.Text & "',b.contactno = '" & TextBox5.Text & "',a.salary = " & TextBox6.Text & ")")


                MessageBox.Show("Record Save Successfully...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call clear()
                textBox1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub clear()
        textBox1.Clear()
        textBox2.Clear()
        textBox3.Clear()
        textBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a As Integer
        Try
            If rs.State Then
                rs.Close()
            End If



            a = InputBox("Enter EmpID... ", "Response", 0)
            rs.Open("Select a.EmpId, a.empName, a.Dept, b.EmailId, b.Contactno, a.Salary From empinfo a, empdetails b where a.empid = b.empid and a.empid = " & a & "", cn, 1, 2)
            If rs.RecordCount > 0 Then
                textBox1.Text = rs.Fields(0).Value
                textBox2.Text = rs.Fields(1).Value
                textBox3.Text = rs.Fields(2).Value
                textBox4.Text = rs.Fields(3).Value
                TextBox5.Text = rs.Fields(4).Value
                TextBox6.Text = rs.Fields(5).Value
                textBox1.Enabled = False
                Button2.Enabled = True
                Button3.Enabled = True
            Else
                MessageBox.Show("Record Not Found... ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As String
        a = MessageBox.Show("Do You Want to Modify This Record... ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            cn.Execute("Update empinfo set empname = '" & textBox2.Text & "', Dept = '" & textBox3.Text & "', salary = " & TextBox6.Text & " where empid = " & textBox1.Text & "")
            cn.Execute("Update empdetails set emailid = '" & textBox4.Text & "', Contactno = '" & TextBox5.Text & "' where empid =  " & textBox1.Text & "")
            MessageBox.Show("Record Modify Successfully...")
            Call clear()
            textBox1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String
        Try

            a = MessageBox.Show("Do You Want to Delete this Record...", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then
                cn.Execute("Delete from empinfo where empid = " & textBox1.Text & " ")
                cn.Execute("Delete from empdetails where empid = " & textBox1.Text & " ")
                MessageBox.Show("Record Deleted Successfully...")
                Call clear()
                textBox1.Enabled = True
                Button2.Enabled = False
                Button3.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class