Public Class Form1
    Private Sub BtnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim num As Integer
        num = Convert.ToInt32(TextBox1.Text)
        If (num Mod 2 = 0) Then
            lblResult.Text = num & " is an even number"
        Else
            lblResult.Text = num & " is an odd number"

        End If
    End Sub
End Class

