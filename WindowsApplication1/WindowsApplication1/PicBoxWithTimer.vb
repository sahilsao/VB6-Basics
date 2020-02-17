Public Class PicBoxWithTimer

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PicBox1.Visible = True Then
            PicBox1.Visible = False
            PicBox2.Visible = True
            PicBox3.Visible = False
            PicBox4.Visible = False
            PicBox5.Visible = False
            PicBox6.Visible = False
            PicBox7.Visible = False
            PicBox8.Visible = False

        ElseIf PicBox2.Visible = True Then
            PicBox2.Visible = False
            PicBox3.Visible = True
            PicBox4.Visible = False
            PicBox5.Visible = False
            PicBox6.Visible = False
            PicBox7.Visible = False
            PicBox8.Visible = False
            PicBox1.Visible = False

        ElseIf PicBox3.Visible = True Then
            PicBox3.Visible = False
            PicBox4.Visible = True
            PicBox5.Visible = False
            PicBox6.Visible = False
            PicBox7.Visible = False
            PicBox8.Visible = False
            PicBox1.Visible = False
            PicBox2.Visible = False

        ElseIf PicBox4.Visible = True Then
            PicBox4.Visible = False
            PicBox5.Visible = True
            PicBox6.Visible = False
            PicBox7.Visible = False
            PicBox8.Visible = False
            PicBox1.Visible = False
            PicBox2.Visible = False
            PicBox3.Visible = False

        ElseIf PicBox5.Visible = True Then
            PicBox5.Visible = False
            PicBox6.Visible = True
            PicBox7.Visible = False
            PicBox8.Visible = False
            PicBox1.Visible = False
            PicBox2.Visible = False
            PicBox3.Visible = False
            PicBox4.Visible = False

        ElseIf PicBox6.Visible = True Then
            PicBox6.Visible = False
            PicBox7.Visible = True
            PicBox8.Visible = False
            PicBox1.Visible = False
            PicBox2.Visible = False
            PicBox3.Visible = False
            PicBox4.Visible = False
            PicBox5.Visible = False

        ElseIf PicBox7.Visible = True Then
            PicBox7.Visible = False
            PicBox8.Visible = True
            PicBox1.Visible = False
            PicBox2.Visible = False
            PicBox3.Visible = False
            PicBox4.Visible = False
            PicBox5.Visible = False
            PicBox6.Visible = False

        ElseIf PicBox8.Visible = True Then
            PicBox8.Visible = False
            PicBox1.Visible = True
            PicBox2.Visible = False
            PicBox3.Visible = False
            PicBox4.Visible = False
            PicBox5.Visible = False
            PicBox6.Visible = False
            PicBox7.Visible = False
        End If
    End Sub
End Class