Imports System.Xml
Public Class jail

    Dim c As String
    Dim k As String = Chr(13) & Chr(10) & "--------------------------------------------"

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        c = Trim(TextBox1.Text)
        If TextBox1.Text = "74269" Then
            Dim PathUserData As String = ReadXML("boot", "jail")
            RichTextBox1.Text = System.IO.File.ReadAllText(PathUserData)
            ButBack.Visible = True
            RichTextBox1.ReadOnly = True
            RichTextBox1.Cursor = Cursors.No
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim puk As String = ReadXML("boot", "jail")
        Try
            Dim twl As String = Now & Chr(13) & Chr(10) & TextBox1.Text & RichTextBox1.Text & k
            Dim PathUserData As String = ReadXML("boot", "jail")
            Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(PathUserData, True, System.Text.Encoding.UTF8)
            t.WriteLine(twl)
            t.Close()
            MessageBox.Show("完成命令：保存", "CAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            RichTextBox1.Clear()
            TextBox1.Clear()
        Catch
            MessageBox.Show("ERROR 401:应用程序在保存时发生了错误", "CAT", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_DoubleClick(sender As Object, e As EventArgs) Handles ButBack.DoubleClick
        Dim PathUserData As String = ReadXML("boot", "jail")
        RichTextBox1.Text = System.IO.File.ReadAllText(PathUserData)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "表扬" Then
            TextBox1.Text = "$&" & TextBox1.Text
        Else
            RichTextBox1.Focus()
            SendKeys.Send(ComboBox1.SelectedItem)
        End If
    End Sub

    Private Sub ButBack_Click(sender As Object, e As EventArgs) Handles ButBack.Click
        TextBox1.Clear()
        RichTextBox1.ReadOnly = False
        RichTextBox1.Clear()
        RichTextBox1.Cursor = Cursors.IBeam
        ButBack.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        RichTextBox1.Redo()
    End Sub
    Private Function statusdot(ByVal okay As Boolean)
        If okay = False Then
            server.Text = "无法连接到服务器"
        Else
            server.Image = Image.FromFile("\\10.75.35.106\server\dots\green.png")
            server.Text = "服务器连接正常"
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

    Private Sub jail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pingserver()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("osk.exe")
    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''''''''boot''''''''''''''''''''''''''''''''''''''''

    Public bootxml As New XmlDocument
    Public xmlread As String
    Public xmlwrite As String
    Public Sub funcxmlLOAD() Handles MyBase.Load
        bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
    End Sub
    Public Function ReadXML(ByVal a As String, ByVal b As String)
        xmlread = bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText
        Return xmlread
    End Function
    Public Function WriteXML(ByVal a As String, ByVal b As String, ByVal w As String)
        xmlwrite = bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText(w)
        Return xmlwrite
    End Function
End Class