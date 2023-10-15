Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Form1
    Private Sub BtnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim g As Graphics
        g = Me.CreateGraphics()
        Dim r As Pen = New Pen(Color.Red, 5)
        Dim g1 As Pen = New Pen(Color.Green, 8)
        Dim b As Pen = New Pen(Color.Blue, 10)

        'g.DrawRectangle(New Pen(Color.Brown, 10), 25, 25, 125, 125)
        g.DrawRectangle(r, 30, 30, 130, 130)
        g.DrawEllipse(g1, 30, 180, 130, 130)
        g.DrawLine(b, 205, 105, 330, 70)

    End Sub

    Private Sub BtnDraw2_Click(sender As Object, e As EventArgs) Handles btnDraw2.Click
        Dim g As Graphics
        g = Me.CreateGraphics()
        Dim r As Pen = New Pen(Color.Red, 5)
        Dim g1 As Pen = New Pen(Color.Green, 8)
        Dim b As Pen = New Pen(Color.Blue, 10)

        g.DrawRectangle(r, 25, 25, 125, 125)
        g.DrawEllipse(g1, 25, 175, 125, 125)
        g.DrawLine(b, 380, 100, 630, 100)
        g.DrawLine(b, 500, 100, 500, 300)
    End Sub

    Private Sub BtnDraw3_Click(sender As Object, e As EventArgs) Handles btnDraw3.Click
        Dim g As Graphics
        g = Me.CreateGraphics()
        Dim r As Pen = New Pen(Color.Red, 5)
        Dim r1 As Pen = New Pen(Color.Yellow, 5)
        Dim g1 As Pen = New Pen(Color.Green, 6)
        Dim b As Pen = New Pen(Color.Blue, 8)

        g.DrawRectangle(r, 25, 25, 825, 470)
        g.DrawRectangle(r, 40, 40, 795, 440)
        g.DrawEllipse(g1, 50, 50, 775, 420)
        g.DrawEllipse(g1, 65, 60, 750, 395)
        g.DrawRectangle(r1, 175, 175, 500, 175)
        g.DrawLine(b, 190, 190, 650, 330)
        g.DrawLine(b, 650, 190, 190, 340)
    End Sub

    Private Sub BtnColorGradiant_Click(sender As Object, e As EventArgs) Handles btnColorGradiant.Click
        Dim g As Graphics
        g = Me.CreateGraphics()
        Dim r As Rectangle = New Rectangle(25, 25, 400, 300)

        Dim sb As SolidBrush = New SolidBrush(Color.Red)
        'g.FillRectangle(sb, r)
        'g.FillRectangle(sb, r)
        'g.FillRectangle(sb, r)
        'g.FillEllipse(sb, r)

        Dim hb As HatchBrush = New HatchBrush(HatchStyle.DarkVertical, Color.Brown, Color.LightSkyBlue)
        g.FillRectangle(hb, r)
        'Dim p As Pen = New Pen(Color.Blue, 5)
        'g.DrawPie(p, 150, 200, 300, 200, 30, 180)
        Dim lb As LinearGradientBrush = New LinearGradientBrush(r, Color.Blue, Color.Red, LinearGradientMode.Vertical)
        g.FillEllipse(lb, r)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        'Dim lstname As ListBox = New System.Windows.Forms.ListBox()
        Dim lstname As ListBox = New ListBox()
        lstname.Size = New Size(150, 200)
        'lstname.Size = New System.Drawing.Size(300, 400)
        'Dim p1 As Pen= New System.Drawing.Pen(Color.Blue,10.5)
        lstname.Location = New Point(30, 20)
        Me.Controls.Add(lstname)

        'How to create button at run time
        Dim btnShow As Button = New Button()
        btnShow.Size = New Size(150, 50)
        btnShow.Location = New Point(200, 20)
        btnShow.Text = "ShowNow"
        btnShow.BackColor = Color.Brown
        btnShow.ForeColor = Color.White
        Me.Controls.Add(btnShow)
        'Que :- explain the working Of clr define manage code In dotnet framework
    End Sub
End Class
