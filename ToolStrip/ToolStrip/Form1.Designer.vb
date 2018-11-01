<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.myToolStrip = New System.Windows.Forms.ToolStrip()
        Me.myToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'myToolStrip
        '
        Me.myToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.myToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.myToolStrip.Name = "myToolStrip"
        Me.myToolStrip.Size = New System.Drawing.Size(572, 25)
        Me.myToolStrip.TabIndex = 0
        Me.myToolStrip.Text = "ToolStrip1"
        '
        'myToolStrip2
        '
        Me.myToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.myToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.myToolStrip2.Name = "myToolStrip2"
        Me.myToolStrip2.Size = New System.Drawing.Size(572, 25)
        Me.myToolStrip2.TabIndex = 1
        Me.myToolStrip2.Text = "ToolStrip1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pic 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(348, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Pic 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(121, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Text"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(348, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 47)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "ComboBox"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(241, 225)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 47)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Merge"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(241, 293)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(136, 47)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Undo Merge"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.myToolStrip2)
        Me.Controls.Add(Me.myToolStrip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents myToolStrip As Windows.Forms.ToolStrip
    Friend WithEvents myToolStrip2 As Windows.Forms.ToolStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
