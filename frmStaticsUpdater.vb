Public Class frmStaticsUpdater
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        updateRecords()
    End Sub

    Private Sub updateRecords()
        allRecords.Clear()
        'base info
        Dim userID As String
        Dim userName As String
        'xml utility
        Dim xmlDocUserInfo As New Xml.XmlDocument
        Dim xmlDocRecords As New Xml.XmlDocument
        Dim xmlEle As Xml.XmlElement
        xmlDocUserInfo.Load(envPath & "Users.xml")
        '加载用户信息
        For i = 0 To xmlDocUserInfo.SelectSingleNode("UserInfo").SelectNodes("User").Count - 1
            pbProgress.Maximum = xmlDocUserInfo.SelectSingleNode("UserInfo").SelectNodes("User").Count
            userID = xmlDocUserInfo.SelectSingleNode("UserInfo").SelectNodes("User")(i).SelectSingleNode("id").InnerText
            userName = xmlDocUserInfo.SelectSingleNode("UserInfo").SelectNodes("User")(i).SelectSingleNode("name").InnerText
            xmlDocRecords.Load(envPath & "RECORD_" & userID.Trim & ".XML")
            '加载记录文件
            For j = 0 To xmlDocRecords.SelectSingleNode("Record").SelectNodes("item").Count - 1
                Dim record As New RecordInfo
                xmlEle = xmlDocRecords.SelectSingleNode("Record").SelectNodes("item")(j)
                record.rentByUserID = userID
                record.rentByUserName = userName
                record.cid = xmlEle.GetAttribute("cid")
                record.model = xmlEle.GetAttribute("model")
                record.note = xmlEle.InnerText
                record.readAfter = xmlEle.GetAttribute("readafter")
                record.readBefore = xmlEle.GetAttribute("readbefore")
                record.rentDate = xmlEle.GetAttribute("rentdate")
                record.returnDate = xmlEle.GetAttribute("returndate")
                record.status = xmlEle.GetAttribute("status")
                allRecords.Add(record)
            Next
            pbProgress.Value += 1
            lbNow.Text = "已完成 " & (pbProgress.Value / pbProgress.Maximum * 100).ToString("###") & "%"
            Application.DoEvents()
        Next
        Close()
    End Sub
End Class