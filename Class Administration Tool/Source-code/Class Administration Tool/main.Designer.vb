<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.一键查看作业ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.启动Commit功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.进入小黑屋ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出工具ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.正常退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.不顾电脑的感受强制退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.重启CATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClaTime = New System.Windows.Forms.Timer(Me.components)
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.UT = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.server = New System.Windows.Forms.ToolStripStatusLabel()
        Me.version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.update = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SoundPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SoundPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "2018/01/01 00:00:00 星期日"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("黑体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(128, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "时辰未到"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Class Administration Tool"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.一键查看作业ToolStripMenuItem, Me.启动Commit功能ToolStripMenuItem, Me.进入小黑屋ToolStripMenuItem, Me.ToolStripSeparator3, Me.退出工具ToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem2, Me.DebugToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 176)
        Me.ContextMenuStrip1.Text = "CAT Menu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Checked = True
        Me.ToolStripMenuItem1.CheckOnClick = True
        Me.ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem1.Text = "最小化到托盘区"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        '一键查看作业ToolStripMenuItem
        '
        Me.一键查看作业ToolStripMenuItem.Name = "一键查看作业ToolStripMenuItem"
        Me.一键查看作业ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.一键查看作业ToolStripMenuItem.Text = "一键查看作业"
        '
        '启动Commit功能ToolStripMenuItem
        '
        Me.启动Commit功能ToolStripMenuItem.Name = "启动Commit功能ToolStripMenuItem"
        Me.启动Commit功能ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.启动Commit功能ToolStripMenuItem.Text = "隐藏功能"
        '
        '进入小黑屋ToolStripMenuItem
        '
        Me.进入小黑屋ToolStripMenuItem.Image = CType(resources.GetObject("进入小黑屋ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.进入小黑屋ToolStripMenuItem.Name = "进入小黑屋ToolStripMenuItem"
        Me.进入小黑屋ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.进入小黑屋ToolStripMenuItem.Text = "进入小黑屋"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(164, 6)
        '
        '退出工具ToolStripMenuItem
        '
        Me.退出工具ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.正常退出ToolStripMenuItem, Me.不顾电脑的感受强制退出ToolStripMenuItem, Me.ToolStripSeparator1, Me.重启CATToolStripMenuItem})
        Me.退出工具ToolStripMenuItem.Name = "退出工具ToolStripMenuItem"
        Me.退出工具ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.退出工具ToolStripMenuItem.Text = "退出此工具"
        '
        '正常退出ToolStripMenuItem
        '
        Me.正常退出ToolStripMenuItem.Name = "正常退出ToolStripMenuItem"
        Me.正常退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.正常退出ToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.正常退出ToolStripMenuItem.Text = "正常退出CAT"
        '
        '不顾电脑的感受强制退出ToolStripMenuItem
        '
        Me.不顾电脑的感受强制退出ToolStripMenuItem.Name = "不顾电脑的感受强制退出ToolStripMenuItem"
        Me.不顾电脑的感受强制退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.不顾电脑的感受强制退出ToolStripMenuItem.ShowShortcutKeys = False
        Me.不顾电脑的感受强制退出ToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.不顾电脑的感受强制退出ToolStripMenuItem.Text = "不顾此电脑的感受，强制退出"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        '重启CATToolStripMenuItem
        '
        Me.重启CATToolStripMenuItem.Name = "重启CATToolStripMenuItem"
        Me.重启CATToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.重启CATToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.重启CATToolStripMenuItem.Text = "重启CAT"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(164, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem})
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem2.Text = "Official Website"
        '
        'AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem
        '
        Me.AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem.Image = CType(resources.GetObject("AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem.Name = "AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem"
        Me.AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem.Text = "Access to the official website on GitHub"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"m", "m1", "m2", "m3", "m4", "n", "a1", "a2", "a3", "a4", "i"})
        Me.ComboBox1.Location = New System.Drawing.Point(235, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(78, 20)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "下节课是："
        '
        'ClaTime
        '
        '
        'T2
        '
        Me.T2.Interval = 1000
        '
        'UT
        '
        Me.UT.Interval = 2000
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(340, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(18, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "小黑屋"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(235, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(36, 173)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(36, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(135, 100)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(68, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.server, Me.version, Me.update})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 250)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(358, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'server
        '
        Me.server.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.server.Image = CType(resources.GetObject("server.Image"), System.Drawing.Image)
        Me.server.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.server.Name = "server"
        Me.server.Size = New System.Drawing.Size(48, 17)
        Me.server.Text = "错误"
        '
        'version
        '
        Me.version.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold)
        Me.version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.version.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.version.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(74, 17)
        Me.version.Text = "^版本信息^"
        '
        'update
        '
        Me.update.Image = CType(resources.GetObject("update.Image"), System.Drawing.Image)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(16, 17)
        '
        'SoundPlayer
        '
        Me.SoundPlayer.Enabled = True
        Me.SoundPlayer.Location = New System.Drawing.Point(320, 25)
        Me.SoundPlayer.Name = "SoundPlayer"
        Me.SoundPlayer.OcxState = CType(resources.GetObject("SoundPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SoundPlayer.Size = New System.Drawing.Size(38, 36)
        Me.SoundPlayer.TabIndex = 0
        Me.SoundPlayer.TabStop = False
        Me.SoundPlayer.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(132, 173)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(68, 57)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(235, 173)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(68, 57)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 16
        Me.PictureBox6.TabStop = False
        '
        'main
        '
        Me.AcceptButton = Me.Button3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(358, 272)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.SoundPlayer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(374, 310)
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Administration Tool"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.SoundPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出工具ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 正常退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 不顾电脑的感受强制退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 重启CATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClaTime As System.Windows.Forms.Timer
    Friend WithEvents T2 As System.Windows.Forms.Timer
    Friend WithEvents UT As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents 一键查看作业ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 进入小黑屋ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents server As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents update As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AccessToTheOfficialWebsiteOnGitHubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoundPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents 启动Commit功能ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
