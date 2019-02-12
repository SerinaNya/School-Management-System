Imports Microsoft.CSharp
Public Class Form1
    Dim c As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        MessageBox.Show("狡猾！狡猾！" & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & "屏幕中间右键退出（滑稽）", "中国金坷垃专用运输车", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.WindowState = FormWindowState.Maximized
        Timer.Enabled = True
        Do Until 

        Loop
    End Sub

    Private Sub scr_Click(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        'If PictureBox3.Visible = False Then PictureBox3.Visible = True Else PictureBox3.Visible = False
        If Me.BackColor = Color.White Then
            Me.BackColor = Color.Black
        ElseIf Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        End
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = ""
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
        Me.TopMost = True
    End Sub
End Class