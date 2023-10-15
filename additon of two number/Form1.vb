Public Class Form1
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1.Text = ""
        txt1.Focus()
    End Sub

    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim num As Integer
        num = Val(txt1.Text)
        If num Mod 2 Then
            MsgBox("Its an odd number")
        Else
            MsgBox("Its an even number")
        End If
    End Sub
End Class
