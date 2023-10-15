Imports tpcDll
Public Class Form1
    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim obj As tpc = New tpc()
        lblResult.Text = obj.sum(txt1.Text, txt2.Text)
        txt1.Text = ""
        txt2.Text = ""
        txt1.Focus()
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim obj As tpc = New tpc()
        lblResult.Text = obj.minus(txt1.Text, txt2.Text)
        txt1.Text = ""
        txt2.Text = ""
        txt1.Focus()
    End Sub
    Private Sub BtnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        Dim obj As tpc = New tpc()
        lblResult.Text = obj.miltiple(txt1.Text, txt2.Text)
        txt1.Text = ""
        txt2.Text = ""
        txt1.Focus()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim obj As tpc = New tpc()
        obj.insert(txtStuid.Text, txtName.Text, txtFname.Text, txtMobile.Text)
    End Sub


End Class
