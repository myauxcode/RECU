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


    Public Sub Ejercicio1_1(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x1, y1, x2, y2 As Single
        Dim r1, vi1, r2, vi2
        Dim my As Single
        Dim i As Integer
        vi1 = ax

        r1 = (bx - ax) / n

        my = (by + ay) / 2

        vi2 = ay

        r2 = (my - ay) / n

        y1 = my

        x2 = bx


        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)
        g.DrawLine(Pens.Red, ax, my, bx, my)

        For i = 1 To n

            x1 = vi1 + (i - 1) * r1
            y2 = vi2 + (i - 1) * r2

            g.DrawLine(Pens.Blue, x1, y1, x2, y2)

            For J = 1 To 99999999

            Next

        Next

    End Sub


    Public Sub Ejercicio1_2(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x1, y1, x2, y2 As Single
        Dim r1, vi1, r2, vi2
        Dim my As Single
        Dim i As Integer
        vi1 = ax

        r1 = (bx - ax) / n

        my = (by + ay) / 2

        vi2 = my

        r2 = (by - my) / n

        y1 = by

        x2 = bx


        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)
        g.DrawLine(Pens.Red, ax, my, bx, my)

        For i = 1 To n
            x1 = vi1 + (i - 1) * r1
            y2 = vi2 + (i - 1) * r2


            g.DrawLine(Pens.Blue, x1, y1, x2, y2)

            For J = 1 To 99999999

            Next

        Next

    End Sub

    Private Sub EJERCICIO1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO1ToolStripMenuItem.Click
        Ejercicio1_1(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Ejercicio1_2(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)

    End Sub


    Public Sub Ejer3(ax As UInt32, bx As UInt32, ay As UInt32, by As UInt32, n As UInt32)

        Dim x, y, A, L As Single
        Dim vi1, r1, vi2, r2, vi3, r3 As Single
        Dim i As Integer

        r1 = ((bx - ax) / n)

        vi1 = bx - r1

        vi2 = ay

        r2 = ((by - ay) / n)

        vi3 = (by - ay)

        r3 = r2

        A = ((bx - ax) / n)


        g.DrawRectangle(Pens.Black, ax, ay, bx - ax, by - ay)

        For i = 1 To n

            x = vi1 - (i - 1) * r1

            y = vi2 + (i - 1) * r2


            L = vi3 - (i - 1) * r3

            g.DrawRectangle(Pens.Blue, x, y, A, L)

        Next

    End Sub

    Private Sub EJERCICIO2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIO2ToolStripMenuItem.Click

        Ejer3(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)

    End Sub

End Class
