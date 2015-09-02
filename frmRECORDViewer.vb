Public Class frmRECORDViewer
    Dim xmlDoc As New Xml.XmlDocument
    Private Sub frmRECORDViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If LoadRecord = "" Or FileIO.FileSystem.FileExists(envPath & LoadRecord) = False Then
                MsgBox("无文件记录")
                Me.Close()
                Exit Sub
            End If
            xmlDoc.Load(envPath & LoadRecord)
            If xmlDoc.SelectSingleNode("Record").SelectNodes("item").Count = 0 Then
                MsgBox("无记录")
            End If
            Dim xmlEle As Xml.XmlElement
            For i = 0 To xmlDoc.SelectSingleNode("Record").SelectNodes("item").Count - 1
                xmlEle = xmlDoc.SelectSingleNode("Record").SelectNodes("item")(i)
                Dim u As New ListViewItem
                u.Text = xmlEle.GetAttribute("model")
                u.SubItems.Add(xmlEle.GetAttribute("cid"))
                u.SubItems.Add(xmlEle.GetAttribute("rentdate"))
                u.SubItems.Add(xmlEle.GetAttribute("readbefore"))
                If xmlEle.GetAttribute("status") = "0" Then
                    u.SubItems.Add("未归还")
                    u.SubItems.Add("-")
                    u.BackColor = Color.OrangeRed
                Else
                    u.SubItems.Add(xmlEle.GetAttribute("returndate"))
                    u.SubItems.Add(xmlEle.GetAttribute("readafter"))
                End If
                u.SubItems.Add(xmlEle.InnerText)
                ListView1.Items.Add(u)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class