Imports System.Xml
Public Class curr
    Dim Xmldoc As New XmlDocument
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xmldoc.Load(ReadXML("boot", "curr"))
        Call curr()
    End Sub

    Private Sub curr()
        Dim wdn As String = Weekday(Date.FromOADate(Today.ToOADate()))
        Dim xq As String = WeekdayName(wdn)
        Label1.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("m").InnerText
        Label2.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("m1").InnerText
        Label3.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("m2").InnerText
        Label4.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("m3").InnerText
        Label5.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("m4").InnerText
        Label6.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("n").InnerText
        Label7.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("a1").InnerText
        Label8.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("a2").InnerText
        Label9.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("a3").InnerText
        Label10.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("a4").InnerText
        Label11.Text = Xmldoc.SelectSingleNode("win").SelectSingleNode(xq).SelectSingleNode("i").InnerText
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