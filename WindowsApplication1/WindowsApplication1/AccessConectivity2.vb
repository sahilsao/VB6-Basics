Public Class AccessConectivity2
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub AccessConectivity2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub AccessConectivity2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'ExcelDataSet.Empinfo' table. You can move, or remove it, as needed.
        Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet.Empinfo)
        Try
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\VB Notes\Excel.accdb"
            cn.Open()
            If rs.State Then
                rs.Close()
            End If
            rs.Open("select * from empdetails order by empid", cn, 1, 2)
            Button2.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If textBox1.Text = "" Or textBox2.Text = "" Or textBox3.Text = "" Or textBox4.Text = "" Then
                MessageBox.Show("Please Fill All Information...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Call clear()
            Else
                cn.Execute("Insert into empinfo values (" & textBox1.Text & ",'" & textBox2.Text & "','" & textBox3.Text & "'," & textBox4.Text & ")")
                MessageBox.Show("Record Save Successfully...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet.Empinfo)
                Call clear()
                Call clear()
                textBox1.Enabled = False
                Button8.Enabled = False
                Button10.Enabled = False
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True

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
        Try
        Dim a As String
        a = MessageBox.Show("Do You Want To Modify This Record...", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            cn.Execute("Update empinfo set empname = '" & textBox2.Text & "',dept = '" & textBox3.Text & "', salary = " & textBox4.Text & " where empid = " & textBox1.Text & " ")
            MessageBox.Show("Record Modify Successfully... ", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet.Empinfo)
                Call clear()
        End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String
        a = MessageBox.Show("Do You Want To Delete This Record... ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            Dim b As Integer
            If rs.State Then
                rs.Close()
            End If
            Try
                b = InputBox("Enter EmpID... ", "Response", 0)
                rs.Open("Select * From empinfo where empid = " & b & "", cn, 1, 2)
                If rs.RecordCount > 0 Then
                    cn.Execute("Delete * From empinfo where empid = " & b & "")
                    MessageBox.Show("Record Delete Successfully...", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.EmpinfoTableAdapter.Fill(Me.ExcelDataSet.Empinfo)
                    Call clear()

                Else
                    MessageBox.Show("Record Deletion Faild")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        textBox1.Enabled = False
        Button10.Enabled = False
        textBox1.Enabled = False
        Button8.Enabled = False
        Button10.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

        On Error Resume Next
        textBox1.Text = DataGridView1.SelectedCells(0).Value.ToString
        textBox2.Text = DataGridView1.SelectedCells(1).Value.ToString
        textBox3.Text = DataGridView1.SelectedCells(2).Value.ToString
        textBox4.Text = DataGridView1.SelectedCells(3).Value.ToString

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Call clear()
        textBox1.Enabled = False
        Button8.Enabled = False
        Button10.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub
    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.EmpinfoTableAdapter.FillBy(Me.ExcelDataSet.Empinfo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.EmpinfoTableAdapter.FillBy1(Me.ExcelDataSet.Empinfo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Call clear()
        textBox1.Enabled = True
        Button8.Enabled = True
        Button10.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        textBox1.Focus()
    End Sub
    Sub records()
        textBox1.Text = rs.Fields(0).Value
        textBox2.Text = rs.Fields(1).Value
        textBox3.Text = rs.Fields(2).Value
        textBox4.Text = rs.Fields(3).Value
        't5.Text = rs.Fields(4).Value
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNext.Click
        Try
            rs.MoveNext()

            If rs.EOF = True Then

                MessageBox.Show("No more records...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                rs.MoveLast()
            Else
                Call records()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub textBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox1.KeyPress
        e.Handled = AllowNumbers(Asc(e.KeyChar))
    End Sub

    Private Sub textBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox2.KeyPress
        e.Handled = AllowCharacter(Asc(e.KeyChar))
    End Sub

    Private Sub textBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox3.KeyPress
        e.Handled = AllowCharacter(Asc(e.KeyChar))
    End Sub

    Private Sub textBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox4.KeyPress
        e.Handled = AllowNumbers(Asc(e.KeyChar))
    End Sub

    Private Sub BFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFirst.Click
        Try

            If rs.State Then
                rs.Close()
            End If
            rs.Open("SELECT * FROM EMPINFO ORDER BY EMPID", cn, 1, 2)

            rs.MoveFirst()
            Call records()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrevious.Click
          rs.MovePrevious()
        If rs.BOF = True Then
            MessageBox.Show("No more records...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rs.MoveFirst()
        Else
            Call records()
        End If
    End Sub

    Private Sub BLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLast.Click
        rs.MoveLast()
        Call records()

    End Sub
End Class