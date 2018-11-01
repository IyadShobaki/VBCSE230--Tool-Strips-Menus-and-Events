Public Class Form1
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If Not ToolStripComboBox1.Text = "" Then
            WebBrowser1.Navigate(ToolStripComboBox1.Text)
            ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)
            If ToolStripComboBox1.Items.Count = 11 Then
                ToolStripComboBox1.Items.RemoveAt(0)
            End If
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        WebBrowser1.Stop()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.Navigate("http://search.msn.com/results.aspx?q=" & ToolStripTextBox1.Text)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim result As DialogResult
        result = OpenFileDialog1.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then
            WebBrowser1.Navigate(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        WebBrowser1.ShowSaveAsDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class
