Public Class AccessConectivity4

    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub AccessConectivity4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmpDetailsTableAdapter.Fill(Me.ExcelDataSet2.empDetails)
        Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet1.Empinfo)
        Try
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\VB Notes\Excel.accdb"
            cn.Open()
            If rs.State Then
                rs.Close()
            End If
            rs.Open("select * from empinfo order by empid", cn, 1, 2)
            If rs.State Then
                rs.Close()
            End If
            rs.Open("select * from empdetails order by empid", cn, 1, 2)
            Button2.Enabled = False
            Button3.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            time.Text = Now.ToLongTimeString.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try

            Call clear()
            textBox1.Enabled = True
            Button8.Enabled = True
            Button10.Enabled = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            textBox1.Focus()
        Catch ex As Exception

        End Try

    End Sub
    Sub clear()
        textBox1.Clear()
        textBox2.Clear()
        textBox3.Clear()
        textBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        textBox1.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If textBox1.Text = "" Or textBox2.Text = "" Or TextBox6.Text = "" Then
                MessageBox.Show("Please Fill EmpId , EmpName & Salary is Campalsary...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call clear()
            Else
                cn.Execute("Insert into empinfo values (" & textBox1.Text & ",'" & textBox2.Text & "','" & textBox3.Text & "'," & TextBox6.Text & ")")
                cn.Execute("Insert into empDetails values (" & textBox1.Text & ",'" & textBox4.Text & "','" & TextBox5.Text & "')")
                MessageBox.Show("Record Save Successfully...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.EmpDetailsTableAdapter.Fill(Me.ExcelDataSet2.empDetails)
                Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet1.Empinfo)
                Call clear()
                textBox1.Focus()
                textBox1.Enabled = False
                Button8.Enabled = False
                Button10.Enabled = False
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True

            End If
        Catch ex As Exception

        End Try
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim a As String
            a = MessageBox.Show("Do You Want to Modify This Record... ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then
                cn.Execute("Update empinfo set empname = '" & textBox2.Text & "', Dept = '" & textBox3.Text & "', salary = " & TextBox6.Text & " where empid = " & textBox1.Text & "")
                cn.Execute("Update empdetails set emailid = '" & textBox4.Text & "', Contactno = '" & TextBox5.Text & "' where empid =  " & textBox1.Text & "")
                MessageBox.Show("Record Modify Successfully...")
                Call clear()
                Me.EmpDetailsTableAdapter.Fill(Me.ExcelDataSet2.empDetails)
                Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet1.Empinfo)

                textBox1.Enabled = True
                Button2.Enabled = False
                Button3.Enabled = False
            End If
        Catch ex As Exception

        End Try

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
                Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet1.Empinfo)
                Me.EmpDetailsTableAdapter.Fill(Me.ExcelDataSet2.empDetails)
                textBox1.Enabled = True
                Button2.Enabled = False
                Button3.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        Call clear()
        textBox1.Enabled = False

        Button10.Enabled = False
        textBox1.Enabled = False
        Button8.Enabled = False
        Button10.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

        On Error Resume Next
        If DataGridView1.SelectedCells(0).Value = DataGridView2.SelectedCells(0).Value Then
            textBox1.Text = DataGridView1.SelectedCells(0).Value.ToString
            textBox2.Text = DataGridView1.SelectedCells(1).Value.ToString
            textBox3.Text = DataGridView1.SelectedCells(2).Value.ToString
            TextBox6.Text = DataGridView1.SelectedCells(3).Value.ToString
            'textBox1.Text = DataGridView2.SelectedCells(0).Value.ToString
            textBox4.Text = DataGridView2.SelectedCells(1).Value.ToString
            TextBox5.Text = DataGridView2.SelectedCells(2).Value.ToString
        Else
            Call clear()
            textBox1.Text = DataGridView1.SelectedCells(0).Value.ToString
            textBox2.Text = DataGridView1.SelectedCells(1).Value.ToString
            textBox3.Text = DataGridView1.SelectedCells(2).Value.ToString
            TextBox6.Text = DataGridView1.SelectedCells(3).Value.ToString
        End If

    End Sub

    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.SelectionChanged
        Call clear()
        textBox1.Enabled = False

        Button10.Enabled = False
        textBox1.Enabled = False
        Button8.Enabled = False
        Button10.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

        On Error Resume Next
        If DataGridView1.SelectedCells(0).Value = DataGridView2.SelectedCells(0).Value Then
            textBox1.Text = DataGridView1.SelectedCells(0).Value.ToString
            textBox2.Text = DataGridView1.SelectedCells(1).Value.ToString
            textBox3.Text = DataGridView1.SelectedCells(2).Value.ToString
            TextBox6.Text = DataGridView1.SelectedCells(3).Value.ToString
            'textBox1.Text = DataGridView2.SelectedCells(0).Value.ToString
            textBox4.Text = DataGridView2.SelectedCells(1).Value.ToString
            TextBox5.Text = DataGridView2.SelectedCells(2).Value.ToString
        Else
            Call clear()
            textBox1.Text = DataGridView2.SelectedCells(0).Value.ToString
            textBox4.Text = DataGridView2.SelectedCells(1).Value.ToString
            TextBox5.Text = DataGridView2.SelectedCells(2).Value.ToString
        End If

    End Sub
    Sub records1()
        Call clear()
        textBox1.Text = rs.Fields(0).Value
        textBox2.Text = rs.Fields(1).Value
        textBox3.Text = rs.Fields(2).Value
        TextBox6.Text = rs.Fields(3).Value
    End Sub
    Sub records2()
        Call clear()
        textBox1.Text = rs.Fields(0).Value
        textBox4.Text = rs.Fields(1).Value
        TextBox5.Text = rs.Fields(2).Value
    End Sub

    Private Sub BFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFirst.Click
        textBox1.Enabled = True
        Try

            If rs.State Then
                rs.Close()
            End If
            rs.Open("SELECT * FROM EMPINFO ORDER BY EMPID", cn, 1, 2)

            rs.MoveFirst()
            Call records1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim res As DialogResult
        OpenFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*"
        res = OpenFileDialog1.ShowDialog
        ' If (vbres == DialogResult .OK ) then
        If res = vbOK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PictureBox1.Image = Image.FromFile("C:\VB Notes\Images\photo1.png")
    End Sub
    
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.EmpDetailsTableAdapter.FillBy(Me.ExcelDataSet2.empDetails)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrevious.Click
        rs.MovePrevious()
        If rs.BOF = True Then
            MessageBox.Show("No more records...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rs.MoveFirst()
        Else
            Call records1()
        End If
    End Sub

    Private Sub BNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNext.Click
        Try
            rs.MoveNext()

            If rs.EOF = True Then

                MessageBox.Show("No more records...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                rs.MoveLast()
            Else
                Call records1()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLast.Click
        textBox1.Enabled = True
        Try

            If rs.State Then
                rs.Close()
            End If
            rs.Open("SELECT * FROM EMPINFO ORDER BY EMPID", cn, 1, 2)

            rs.MoveLast()
            Call records1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try

            If rs.State Then
                rs.Close()
            End If
            rs.Open("SELECT * FROM EMPDetails ORDER BY EMPID", cn, 1, 2)

            rs.MoveFirst()
            Call records2()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        rs.MovePrevious()
        If rs.BOF = True Then
            MessageBox.Show("No more records...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rs.MoveFirst()
        Else
            Call records2()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            rs.MoveNext()

            If rs.EOF = True Then

                MessageBox.Show("No more records...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                rs.MoveLast()
            Else
                Call records2()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        rs.MoveLast()
        Call records2()
    End Sub
End Class