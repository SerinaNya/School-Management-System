Imports System.Xml

Public Class main
    Dim wdn As String = Weekday(Date.FromOADate(Today.ToOADate()))
    Dim xmlDoc As New XmlDocument
    Dim bootxml As New XmlDocument
    Dim sersta As Boolean
    Dim directserver As Boolean = False
    Public kcb As String
    Public noticetext As String
    Dim atod As String = DatePart("yyyy", Today) & "-" & DatePart("m", Today) & "-" & DatePart("d", Today)

    Public Sub restart_ing()
        clo = 0
        Application.Exit()
        Application.Restart()
    End Sub

    Dim subj As String
    Public clo As Integer = 1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If clo = 1 Then
            Me.Hide()
            e.Cancel = True
        ElseIf clo = 0 Then
            e.Cancel = False
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
        Me.Hide()
        SplashScreen1.Show()
        T2.Enabled = True
        ClaTime.Enabled = True
        Dim wdn As String = Weekday(Date.FromOADate(Today.ToOADate()))
        Timer1.Enabled = True
        'xmlDoc.Load("\\192.168.1.111\server\curriculum\curr.xml")
        UT.Enabled = True
        update.Visible = False
        version.Text = Application.ProductName & " " & Application.ProductVersion
        Call pingserver()
        Call up()
        Label2.Left = Me.Width / 2 - Label2.Width / 2
    End Sub

    Public Function statusdot(ByVal okay As Boolean)
        Dim sersta As Boolean
        If okay = False Then
            server.Text = "错误"
            ComboBox1.Enabled = False
            ComboBox1.Cursor = Cursors.No
            sersta = False
        Else
            server.Image = Image.FromFile("E:\SMS\IMG\green.png")
            server.Text = "正常"
            bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
            xmlDoc.Load(ReadXML("boot", "curr"))
            sersta = True
        End If
        Return okay
    End Function

    Private Sub pingserver()
        If My.Computer.FileSystem.DirectoryExists(ReadXML("boot", "server")) = False Then
            statusdot(False)
            MessageBox.Show("此电脑与服务器的连接发生了错误，主要功能可能无法使用。您可以重新启动此应用以试图重新连接。", "服务器连接错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            directserver = True
        Else
            statusdot(True)
            noticetext = "即将重启应用程序……"
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim wdn As String = Weekday(Date.FromOADate(Today.ToOADate()))
        Label1.Text = Now & "  " & WeekdayName(wdn)
        'Call pingserver()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
    End Sub

    Private Sub Form1_MinimumSizeChanged(sender As Object, e As EventArgs) Handles Me.MinimumSizeChanged
        Me.Hide()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub ComboBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseDoubleClick
        ComboBox1.Visible = False

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "m" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m").InnerText
        ElseIf ComboBox1.Text = "m1" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m1").InnerText
        ElseIf ComboBox1.Text = "m2" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m2").InnerText
        ElseIf ComboBox1.Text = "m3" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m3").InnerText
        ElseIf ComboBox1.Text = "m4" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m4").InnerText
        ElseIf ComboBox1.Text = "n" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("n").InnerText
        ElseIf ComboBox1.Text = "a1" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a1").InnerText
        ElseIf ComboBox1.Text = "a2" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a2").InnerText
        ElseIf ComboBox1.Text = "a3" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a3").InnerText
        ElseIf ComboBox1.Text = "a4" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a4").InnerText
        ElseIf ComboBox1.Text = "i" Then
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("i").InnerText
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("C:\Users\1h\Desktop\Project\bq.ppsx")
    End Sub

    Private Sub ContextMenuStrip1_ToolStripMenuItem1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ToolStripMenuItem1.Checked = True Then
            clo = 1
        ElseIf ToolStripMenuItem1.Checked = False Then
            clo = 0
        End If
    End Sub

    Private Sub 不顾电脑的感受强制退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 不顾电脑的感受强制退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 正常退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 正常退出ToolStripMenuItem.Click
        clo = 0
        Application.Exit()
    End Sub

    Private Sub 重启CATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重启CATToolStripMenuItem.Click
        Call restart_ing()
    End Sub

    ''clatime''
    Private Sub ClaTime_Tick(sender As Object, e As EventArgs) Handles ClaTime.Tick
        If TimeOfDay = "7:20:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "8:02:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m1").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "8:42:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m2").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "9:58:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m3").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "10:53:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("m4").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "11:42:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("n").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "12:50:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a1").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "13:42:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a2").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "14:38:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a3").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "15:33:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("a4").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        ElseIf TimeOfDay = "16:21:00" Then
            Me.Show()
            Label2.Text = xmlDoc.SelectSingleNode("win").SelectSingleNode(WeekdayName(wdn)).SelectSingleNode("i").InnerText
            SoundPlayer.URL = Application.StartupPath & "\config\sound.wav"
        End If
       
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim lasc As Integer
        lasc = Asc((e.KeyChar))
        Select Case lasc
            Case 27
                clo = 0
                Application.Exit()
        End Select
    End Sub

    Private Sub 一键查看作业ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 一键查看作业ToolStripMenuItem.Click
        job.Show()
    End Sub

    Private Sub 进入小黑屋ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 进入小黑屋ToolStripMenuItem.Click
        jail.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        jail.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        job.Show()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''新版验证
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If InputBox("请输入管理员密码", "管理员") = "74269" Then jail.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\csp\CSP.exe")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        curr.Show()
    End Sub
    Dim tx2 As Integer
    Private Sub T2_Tick(sender As Object, e As EventArgs) Handles T2.Tick
        tx2 += 1
        If tx2 = 5 Then
            SplashScreen1.Close()
            T2.Enabled = False
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        System.Diagnostics.Process.Start("https://bilibili.com")
    End Sub




    '''''''''''''''''''''''''''''''''''''''''''''''''''boot''''''''''''''''''''''''''''''''''''''''




    'Public Sub funcxmlLOAD() Handles MyBase.Load
    '    bootxml.Load(Application.StartupPath & "\config\server-boot.xml")
    'End Sub
    Public Function ReadXML(ByVal a As String, ByVal b As String)
        Dim xmlread As String
        xmlread = bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText
        Return xmlread
    End Function
    Public Function WriteXML(ByVal a As String, ByVal b As String, ByVal w As String)
        Dim xmlwrite As String
        xmlwrite = bootxml.SelectSingleNode(a).SelectSingleNode(b).InnerText(w)
        Return xmlwrite
    End Function

    Private Sub up()
        If sersta = True Then
            If ReadXML("boot", "update") <> "none" Then
                Dim upxml As New XmlDocument
                upxml.Load(ReadXML("boot", "update"))
                If upxml.SelectSingleNode("update").SelectSingleNode("TF").InnerText() = "T" Then
                    update.Visible = True
                    If MessageBox.Show("SMS有可用的更新，即将跳转到控制台。点击确定获取代码，如已更新请点取消", "更新", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.OK Then
                        MessageBox.Show("请牢记您的控制码：01", "获取控制码", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        System.Diagnostics.Process.Start(Application.StartupPath & "\console\SMS-CON.exe")
                        End
                    Else
                        update.Visible = False
                    End If
                Else
                    update.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim pa As String = "https://www.geogebra.org/geometry?from=SMS"
        System.Diagnostics.Process.Start(pa)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim pa As String = "C:\Users\1h\AppData\Roaming\Lantern\lantern.exe"
        System.Diagnostics.Process.Start(pa)
    End Sub

    Private Sub 启动Commit功能ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 启动Commit功能ToolStripMenuItem.Click
        tranout.ShowDialog()
    End Sub

    Private Sub start_CSP(ByVal 延时 As Integer)

    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        notice.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.MouseDoubleClick
        ComboBox1.Visible = True
    End Sub
End Class
