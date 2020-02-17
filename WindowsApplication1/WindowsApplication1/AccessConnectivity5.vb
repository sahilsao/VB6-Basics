Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO

Public Class AccessConnectivity5
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim cmd As New OleDbCommand
    Dim dap As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim var As New Integer
    Dim ms As MemoryStream
    Dim photo_aray As Byte()

    Private Sub AccessConnectivity5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0; data source=C:\VB Notes\Excel.accdb"
            cn.Open()

            If rs.State Then
                rs.Close()
            End If

            ' rs.Open("select * from testing order by receiptno", cn, 1, 2)
            Button2.Enabled = False
            Button3.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        cn.Execute("Insert into Testing values('" & textBox1.Text & "','" & textBox2.Text & "','" & textBox3.Text & "'," & textBox4.Text & ")")
        'Call conv_photo()
            MessageBox.Show("Record is added")
                 MessageBox.Show("Record is not added")

    End Sub
    Sub conv_photo()
        ' Dim ms As New MemoryStream()
        ' PictureBox1.Image.Save(ms, ImageFormat.Jpeg)
        ' Dim photo_aray = New  Byte.[ms].Length]
        ' ms.opsition = 0

    End Sub
End Class