Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim atoolstripitem As ToolStripItem
        atoolstripitem = myToolStrip.Items.Add(My.Resources.Lamborghini)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim btoolstripitem As ToolStripItem
        btoolstripitem = myToolStrip2.Items.Add(My.Resources.Jaguar)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim atoolstripitem As ToolStripItem
        atoolstripitem = myToolStrip.Items.Add("Sample text")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ats As New ToolStripComboBox
        ats.DropDownStyle = ComboBoxStyle.DropDownList
        ats.AutoSize = False
        ats.Width = 150
        ats.Items.Add("One")
        ats.Items.Add("Two")
        ats.Items.Add("Three")
        myToolStrip.Items.Add(ats)
        ats.SelectedIndex = 0

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ToolStripManager.Merge(myToolStrip2, myToolStrip)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ToolStripManager.RevertMerge(myToolStrip)
    End Sub
End Class
