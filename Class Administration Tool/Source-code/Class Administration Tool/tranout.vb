Imports System.Xml
Public Class tranout
    Public user_count As Long
    Private Sub commit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pingserver()
        Call load_user()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("osk.exe")
    End Sub


    Private Sub TrackBar_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar.ValueChanged
        ProgressBar1.Value = TrackBar.Value
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then TextBox1.Enabled = True Else TextBox1.Enabled = False
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

    Public Sub load_user()
        Dim xmldoc As XmlDocument = New XmlDocument
        xmldoc.Load(Application.StartupPath & "\config\name-list.xml")
        Dim xml_object As XmlNode
        xml_object = xmldoc.SelectSingleNode("/list")
        If xml_object Is Nothing Then
            MessageBox.Show("XML缺少list元素，将无法读取配置信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim user_node As XmlNodeList
        user_node = xml_object.SelectNodes("//name")
        ''添加用户'''
        user_count = user_node.Count
        Dim user As String
        For i = 0 To user_node.Count - 1
            user = Trim(user_node.Item(i).FirstChild.InnerText)
            namecom.Items.Add(user)
        Next
    End Sub
    Public Sub load_job()
        Dim xmldoc As XmlDocument = New XmlDocument
        xmldoc.Load(Application.StartupPath & "\config\job-list.xml")
        Dim xml_object As XmlNode
        '判断科目
        Dim subje As String
        subje = ""
        If subcom.Text = "语文" Then
            subje = "chi"
        ElseIf subcom.Text = "数学" Then
            subje = "math"
        ElseIf subcom.Text = "英语" Then
            subje = "eng"
        ElseIf subcom.Text = "其他" Then
            subje = "other"
        End If
        xml_object = xmldoc.SelectSingleNode("/list/" & subje)
        If xml_object Is Nothing Then
            MessageBox.Show("XML缺少list元素，将无法读取配置信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim user_node As XmlNodeList

        user_node = xml_object.SelectNodes("//job")
        ''添加'''
        user_count = user_node.Count
        Dim user As String
        For i = 0 To user_node.Count - 1
            'user = Trim(user_node.Item(i).FirstChild.InnerText)
            user = user_node.Item(i).FirstChild.InnerText
            brancom.Items.Add(user)
        Next
    End Sub

    Private Sub subcom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subcom.SelectedIndexChanged
        Call load_job()
    End Sub
End Class