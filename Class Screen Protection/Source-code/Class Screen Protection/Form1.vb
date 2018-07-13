Imports Microsoft.CSharp
Public Class Form1
    Dim c As String
    Dim k As String = Chr(13) & Chr(10) & "--------------------------------------------"
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub scr_Click(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        'If PictureBox3.Visible = False Then PictureBox3.Visible = True Else PictureBox3.Visible = False
        If Me.BackColor = Color.White Then
            Me.BackColor = Color.Black
        ElseIf Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub 黑屏ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(Application.StartupPath & "\config\Screen.ppsx")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        End
    End Sub
    Private Sub cs()


        End Using

    End Sub
End Class