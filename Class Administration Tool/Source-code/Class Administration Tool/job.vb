Imports System.Xml

Public Class job

    Dim desktop As String = "C:\Users\" & Environment.UserName & "\Desktop"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(ReadXML("boot", "job"))
        
        Call pingserver()
        'F5
        WebBrowser1.Focus()
        SendKeys.Send("{F5}")
    End Sub


    Private Sub 打开HomeworkmhtToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start(ReadXML("boot", "job"))
    End Sub


    Private Sub 重启软件ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        main.clo = 0
        Call main.restart_ing()
    End Sub

    Private Sub 截图ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 截图ToolStripMenuItem.Click
        Me.Refresh()
        Dim memory As Image = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(memory)
        g.CopyFromScreen(Me.Left, Me.Top, 0, 0, New Size(Me.Width, Me.Height)) '这里是截屏核心代码
        Dim FilePath As String = ""
        Dim d As New SaveFileDialog
        d.Filter = "JPEG图像|*.jpeg"
        d.FileName = DatePart("yyyy", Today) & "-" & DatePart("m", Today) & "-" & DatePart("d", Today) & "的作业"
        d.InitialDirectory = desktop
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            FilePath = d.FileName
            If FilePath = "" Then Exit Sub
            'If FilePath.Substring(FilePath.Length - 1, 1) <> "\" Then FilePath = FilePath & "\"
        Else
            Exit Sub
        End If
        d.Dispose()
        memory.Save(FilePath)
        MessageBox.Show("图像已经保存到： " & FilePath, "已保存", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub 刷新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刷新ToolStripMenuItem.Click
        If server.Text = "无法连接到服务器10.75.35.106" Then

        End If
        WebBrowser1.Focus()
        SendKeys.Send("{F5}")
    End Sub

    Private Function statusdot(ByVal okay As Boolean)
        If okay = False Then
            'server.Image = Image.FromFile("\\192.168.1.111\server\dots\red.png")
            server.Text = "无法连接到服务器10.75.35.106"
        Else
            server.Image = Image.FromFile("\\10.75.35.106\server\dots\green.png")
            server.Text = "服务器连接正常"
            RESLOCAL.Text = "资源本地化已关闭"
            RESLOCAL.Image = Image.FromFile("\\10.75.35.106\server\dots\red.png")
        End If
        Return okay
    End Function

    Private Sub pingserver()
        If My.Computer.FileSystem.DirectoryExists("\\10.75.35.106\server") = False Then
            statusdot(False)
        Else
            statusdot(True)
        End If
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''boot''''''''''''''''''''''''''''''''''''''''

    'Public bootxml As New XmlDocument
    'Public xmlread As String
    'Public xmlwrite As String
    Public Sub funcxmlLOAD() Handles MyBase.Load
        Dim bootxml As New XmlDocument
        bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
    End Sub
    Public Function ReadXML(ByVal a As String, ByVal b As String)
        Dim bootxml As New XmlDocument
        bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
        'xmlread = bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText
        Return bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText
    End Function
    Public Function WriteXML(ByVal a As String, ByVal b As String, ByVal w As String)
        Dim bootxml As New XmlDocument
        bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
        'xmlwrite = bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText(w)
        Return bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText(w)
    End Function

   
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        System.Diagnostics.Process.Start(ReadXML("boot", "job"))
    End Sub
End Class