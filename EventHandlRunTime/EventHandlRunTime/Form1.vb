Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RemoveHandler Button1.Click, AddressOf Button1_Click
        AddHandler Button1.Click, AddressOf myHandler
    End Sub
    Private Sub myHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("My new Hello")
    End Sub
End Class
