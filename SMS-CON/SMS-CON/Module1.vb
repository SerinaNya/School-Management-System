Imports System.Xml
Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        Console.Title = "School-Management-System-CONSOLE"
        Console.WriteLine("School-Management-System-控制台")
        Console.Write("请输入您的控制码:")
        Dim concode As String
        Dim un As String = Environment.UserName
        Dim deskpath As String = "C:\Users\" & un & "\Desktop\SMS安装包下载"
        concode = Console.ReadLine
        Try
            REM -------------------------------------------------01-start-----------------------------
            If concode = "01" Then
                i("正在创建实例……")
                Dim bootxml As New XmlDocument
                'Console.WriteLine("实例已创建")
                i("正在检测下载文件夹是否存在")
                Dim downpath As Boolean
                If My.Computer.FileSystem.DirectoryExists(deskpath) = True Then
                    downpath = True
                Else
                    downpath = False
                    My.Computer.FileSystem.CreateDirectory(deskpath)
                End If
                i("正在寻找本地XML")
                bootxml.Load(AppDomain.CurrentDomain.BaseDirectory & "config\server-boot.xml")
                'Console.WriteLine("本地XML已找到")

                i("正在读取本地XML节点")
                Dim uppath As String = bootxml.SelectSingleNode("boot").SelectSingleNode("update").InnerText
                'Console.WriteLine("本地XML节点已读取")

                
                If downpath = True Then
                    My.Computer.FileSystem.CopyFile(uppath, deskpath & "\install.exe", True)
                Else
                    My.Computer.FileSystem.CopyFile(uppath, deskpath & "\install.exe", True)
                End If


                i("正在下载GUI安装应用")
                'My.Computer.FileSystem.CopyFile(uppath, "C:\Program Files\SMS\UPDATE\install.exe", True)
                'Console.WriteLine("GUI安装应用已下载")

                i("正在打开GUI安装程序……")
                MsgBox("请用户完成安装，无法自动安装", MsgBoxStyle.Information)
                System.Diagnostics.Process.Start(deskpath & "\install.exe")
                i("请用户完成安装，无法自动安装")
                Console.Read()
            End If
            REM -------------------------------------------------01-end---------------------------------
            If concode = "jail" Then
                Console.Write("请输入班级代码：")
                Dim ss As String = Console.ReadLine
                Dim PathUserData As String = "\\ADMIN-PCZZM\Server\jail\" & ss & ".jail"
                Console.WriteLine("以下为小黑屋记录：")
                Console.WriteLine(System.IO.File.ReadAllText(PathUserData))
                'MsgBox(System.IO.File.ReadAllText(PathUserData))
                Console.Read()
            End If

            REM ------------------------------------------------jail-start------------------------------

        Catch ex As System.Exception
            Console.BackgroundColor = ConsoleColor.Red
            Console.WriteLine("控制台发生了错误，以下为错误报告：")
            Console.WriteLine("")
            Console.WriteLine(ex)
            Console.BackgroundColor = ConsoleColor.Black
            Console.ReadLine()
        End Try
    End Sub

    Private Function i(ByVal word As String)
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine(word)
        Console.BackgroundColor = ConsoleColor.Yellow
        Return word
    End Function

    
End Module
