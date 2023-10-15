Public Class Form1
    Private Sub SumBtn_Click(sender As Object, e As EventArgs) Handles sumBtn.Click
        Dim first, second, third, totalSum As Integer
        first = Convert.ToInt32(Txt1.Text)
        second = Convert.ToInt32(txt2.Text)
        third = Convert.ToInt32(txt3.Text)
        totalSum = first + second + third
        sumLbl.Text = totalSum.ToString()
        Txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        Txt1.Focus()


    End Sub
End Class
