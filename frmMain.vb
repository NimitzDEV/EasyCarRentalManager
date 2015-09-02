
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        lbVersion.Text = Application.ProductVersion
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        initData()
    End Sub

    Private Sub initData()
        lbStatus.Text = "正在创建数据环境..."
        If FileIO.FileSystem.DirectoryExists(Application.StartupPath & "\SystemData\") = False Then
            MkDir(Application.StartupPath & "\SystemData\")
            showHelpIntro = True
        End If
        If FileIO.FileSystem.FileExists(Application.StartupPath & "\SystemData\Users.xml") = False Then
            showHelpIntro = True
            Dim xmlCreator As New Xml.XmlDocument
            xmlCreator.LoadXml("<?xml version=""1.0"" encoding=""utf-8"" ?><UserInfo></UserInfo>")
            xmlCreator.Save(Application.StartupPath & "\SystemData\Users.xml")
        End If
        Me.Hide()
        mdiMain.Show()
    End Sub
End Class
