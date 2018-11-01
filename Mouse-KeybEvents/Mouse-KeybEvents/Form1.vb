Public Class Form1
    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter

    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Button1.Location = New Point(100, 100)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Label1.Text = e.X
        Label2.Text = e.Y
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            MessageBox.Show("Control button pressed")
        End If
        If e.Alt Then
            MessageBox.Show("Alt button pressed")
        End If
        If e.KeyCode = Keys.C Then
            MessageBox.Show("C button prssed")

        End If
        If e.Shift And e.KeyCode = Keys.X Then
            MessageBox.Show("Shift + X pressed")
        End If
    End Sub
End Class
