Public Class frmCustoms_New
    Dim writeKey() As String = {"id", "name", "sex", "phone", "dial", "addr", "note"}
    Dim writeSouce() As Object
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '验证
        If tbID.Text.Trim = "" Or
                tbName.Text.Trim = "" Or
                cbSex.SelectedIndex = -1 Or tbAddress.Text.Trim = "" Then
            MsgBox("客户信息不全")
            Exit Sub
            '电话号码
            If tbPhoneNumber.Text.Trim = "" And tbDial.Text.Trim = "" Then
                MsgBox("必须预留其中一个联系号码")
                Exit Sub
            End If
        End If
        '身份证号码验证过程
        If CheckIDCard(tbID.Text.Trim) = False Then
            MsgBox("身份证号码无法通过验证")
            Exit Sub
        End If
        '写入信息
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.Load(envPath & "Users.xml")
        Dim xmlUser As Xml.XmlElement
        xmlUser = xmlDoc.CreateElement("User")
        writeSouce = {tbID.Text, tbName.Text, cbSex.SelectedIndex, tbPhoneNumber.Text, tbDial.Text, tbAddress.Text, tbNote.Text}
        For i = 0 To writeKey.Count - 1
            xmlUser.AppendChild((xmlDoc.CreateElement(writeKey(i)))).AppendChild(xmlDoc.CreateCDataSection(writeSouce(i)))
        Next
        xmlDoc.SelectSingleNode("UserInfo").AppendChild(xmlUser)
        xmlDoc.Save(envPath & "Users.xml")
        '新增记录
        Dim xmlDocR As New Xml.XmlDocument
        xmlDocR.LoadXml("<?xml version=""1.0"" encoding=""utf-8"" ?><Record></Record>")
        xmlDocR.Save(envPath & "RECORD_" & tbID.Text.Trim & ".XML")
        If cbRantNow.Checked Then
            PreInputID = tbID.Text.Trim
            mdiMain.出租ToolStripMenuItem.PerformClick()
        End If
        Me.Close()
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        If CheckIDCard(tbID.Text) Then
            Dim xmlDoc As New Xml.XmlDocument
            xmlDoc.Load(envPath & "Users.xml")
            For i = 0 To xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User").Count - 1
                If tbID.Text.Trim = xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User")(i).SelectSingleNode("id").InnerText.Trim Then
                    MsgBox("身份证号码：" & tbID.Text & " - 客户已存在")
                    PreInputID = tbID.Text.Trim
                    mdiMain.出租ToolStripMenuItem.PerformClick()
                    Close()
                    Exit Sub
                End If
            Next
            If Int(Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(tbID.Text, 2), 1)) Mod 2 = 0 Then
                cbSex.SelectedIndex = 1
            Else
                cbSex.SelectedIndex = 0
            End If
            Exit Sub
        End If
        cbSex.SelectedIndex = -1
    End Sub

    Private Sub frmCustoms_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PreInputID <> "" Then
            tbID.Text = PreInputID
        End If
        PreInputID = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class