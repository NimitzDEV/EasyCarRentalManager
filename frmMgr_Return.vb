Public Class frmMgr_Return
    Dim matched As Boolean = False
    Dim xmlDoc As New Xml.XmlDocument
    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If tbID.Text.Trim = "" Then Exit Sub
        lbUserName.Text = isRegUser(tbID.Text)
        If lbUserName.Text <> "" Then
            lbUserName.Text = "客户姓名：" & lbUserName.Text
            btnComfirm.Enabled = False
            tbID.ReadOnly = True
            Me.Height = btnOK.Top + btnOK.Height + (Me.Height - Me.ClientRectangle.Height) + 10
            matched = True
        End If
        If Not matched Then
            MsgBox("无此用户")
            Me.Close()
            Exit Sub
        End If
        refreshList()
        GroupBox1.Visible = True
    End Sub

    Private Sub frmMgr_Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = GroupBox1.Top + (Me.Height - Me.ClientRectangle.Height)
        xmlDoc.Load(envPath & "Users.xml")
    End Sub

    Private Sub tbID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnComfirm.PerformClick()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If MsgBox("确认归还？"， MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim xmlEle As Xml.XmlElement
        xmlEle = xmlDoc.SelectSingleNode("Record").SelectNodes("item")(lvUnreturn.SelectedItems(0).Tag)
        xmlEle.SetAttribute("returndate", tbReturnDate.Text)
        xmlEle.SetAttribute("readafter", tbRead.Text.Trim)
        xmlEle.SetAttribute("status", "1")
        Dim CDATA As Xml.XmlCDataSection = xmlDoc.CreateCDataSection(tbNote.Text.Trim)
        xmlDoc.SelectSingleNode("Record").SelectNodes("item")(lvUnreturn.SelectedItems(0).Tag).InnerText = ""
        xmlDoc.SelectSingleNode("Record").SelectNodes("item")(lvUnreturn.SelectedItems(0).Tag).AppendChild(CDATA)
        xmlDoc.Save(envPath & "RECORD_" & tbID.Text.Trim & ".XML")
        refreshList()
        If lvUnreturn.Items.Count = 0 Then
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbReturnDate.Text = DateTime.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub refreshList()
        tbRead.Text = ""
        tbNote.Text = ""
        btnOK.Visible = False
        lvUnreturn.Items.Clear()
        '加载未归还记录
        xmlDoc.Load(envPath & "RECORD_" & tbID.Text.Trim & ".XML")
        Dim xmlEle As Xml.XmlElement
        For i = 0 To xmlDoc.SelectSingleNode("Record").SelectNodes("item").Count - 1
            xmlEle = xmlDoc.SelectSingleNode("Record").SelectNodes("item")(i)
            If xmlEle.GetAttribute("status") = "0" Then
                Dim u As New ListViewItem
                u.Text = xmlEle.GetAttribute("rentdate")
                u.SubItems.Add(xmlEle.GetAttribute("model"))
                u.SubItems.Add(xmlEle.GetAttribute("cid"))
                u.Tag = i
                lvUnreturn.Items.Add(u)
            End If
        Next
    End Sub

    Private Sub lvUnreturn_Click(sender As Object, e As EventArgs) Handles lvUnreturn.Click
        If lvUnreturn.SelectedItems.Count = 0 Then
            btnOK.Visible = False
            Exit Sub
        End If
        Dim xmlEle As Xml.XmlElement
        xmlEle = xmlDoc.SelectSingleNode("Record").SelectNodes("item")(lvUnreturn.SelectedItems(0).Tag)
        tbNote.Text = xmlEle.InnerText
        btnOK.Visible = True
    End Sub

    Private Sub lvUnreturn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUnreturn.SelectedIndexChanged
        If lvUnreturn.SelectedItems.Count = 0 Then
            btnOK.Visible = False
        End If
    End Sub
End Class