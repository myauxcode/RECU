Public Class Form1

    Dim g As Graphics


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = PictureBox1.CreateGraphics
    End Sub



    Public Sub Marco()
        g.DrawRectangle(Pens.Black, 0, 0, PictureBox1.Width - 1, PictureBox1.Height - 1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label1.Text = PictureBox1.Width()
        Label2.Text = PictureBox1.Height()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Refresh()

    End Sub
    'ejercicio 1
    Public Sub Ejercicio1(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x, y, A, L As Single
        Dim r1, vi1, r2, vi2, r3, vi3, vi, r, mx As Single
        Dim i As Integer
        mx = (bx + ax) / 2

        r1 = (mx - ax) / (n * 2 + 1)  '//2  
        vi1 = (ax + r1)
        r2 = r1 * 2
        vi2 = (mx - ax) - r2 '////////
        r3 = (by - ay) / (n + 1)
        vi3 = (by - ay) - r3

        vi = ay + r3 '///////+ r3
        g.DrawLine(Pens.Black, mx, ay, mx, by)
        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)

        For i = 1 To n

            x = vi1 + (i - 1) * r1
            y = vi + (i - 1) * r3 '///////
            A = vi2 - (i - 1) * r2
            L = vi3 - (i - 1) * r3

            g.DrawRectangle(Pens.Blue, x, y, A, L)

        Next

    End Sub

    Private Sub EJERCICIO1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO1ToolStripMenuItem.Click
        Ejercicio1(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)

    End Sub

    'pregunata 2

    Public Sub Ejercicio2(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x1, y1, x2, y2 As Single
        Dim vi1, r1, vi2, r2, vi3, r3, mmx, my, mx As Single
        Dim i As Integer
        Dim ban As Boolean
        ban = True

        mx = (bx + ax) / 2
        x1 = mx

        y1 = ay + Rnd() * (by - ay)



        g.DrawRectangle(Pens.Black, mx, ay, bx - mx, by - ay)
        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)

        For i = 1 To n

            If ban = True Then
                x2 = bx
            Else
                x2 = mx

            End If

            ban = Not ban
            y2 = ay + Rnd() * (by - ay)

            g.DrawLine(Pens.Blue, x1, y1, x2, y2)
            x1 = x2

            y1 = y2

        Next

    End Sub






    Private Sub EJERCICIO2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO2ToolStripMenuItem.Click

        ejercicio2(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)


    End Sub


End Class
