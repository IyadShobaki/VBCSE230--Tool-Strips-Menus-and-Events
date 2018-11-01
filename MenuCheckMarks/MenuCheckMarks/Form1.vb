Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckMeToolStripMenuItem.CheckState = CheckState.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tss As New ToolStripSeparator
        MenuStrip1.Items.Insert(1, tss)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuStrip2.Items.Add(CheckMeToolStripMenuItem)
        MenuStrip2.Items.Insert(1, TwoToolStripMenuItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        View2ToolStripMenuItem.DropDownItems.Add(CheckMeToolStripMenuItem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MenuStrip2.Items.Remove(View2ToolStripMenuItem)
        TwoToolStripMenuItem.DropDownItems.Remove(ThreeToolStripMenuItem)
        CheckMeToolStripMenuItem.Enabled = False
        TwoToolStripMenuItem.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Controls.Remove(MenuStrip1)
        Me.Controls.Add(MenuStrip2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Controls.Add(MenuStrip1)
        Me.Controls.Remove(MenuStrip2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ContextMenuStrip1.Items.Add(CheckMeToolStripMenuItem)
        ContextMenuStrip1.Items.Remove(HelpToolStripMenuItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button8.ContextMenuStrip = ContextMenuStrip1
        Dim anItem As ToolStripMenuItem
        anItem = New ToolStripMenuItem(CheckMeToolStripMenuItem.Text, My.Resources.Jaguar, New EventHandler(AddressOf CheckMeToolStripMenuItem_Click), "checkme2")
        ContextMenuStrip1.Items.Add(anItem)
    End Sub

    Private Sub CheckMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckMeToolStripMenuItem.Click
        CheckMeToolStripMenuItem.Checked = True
    End Sub
End Class
