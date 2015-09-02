Public Class frmMgr_Rent
    Dim unReturn As Integer = 0
    Dim matched As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbRentTime.Text = DateTime.Now
    End Sub

    Private Sub frmMgr_Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = GroupBox1.Top + (Me.Height - Me.ClientRectangle.Height)
        tbID.Text = PreInputID
        If PreInputID <> "" Then
            btnComfirm.PerformClick()
        End If
        PreInputID = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If tbID.Text.Trim = "" Then Exit Sub
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.Load(envPath & "Users.xml")
        lbUserName.Text = isRegUser(tbID.Text)
        If lbUserName.Text <> "" Then
            lbUserName.Text = "客户姓名：" & lbUserName.Text
            btnComfirm.Enabled = False
            tbID.ReadOnly = True
            Me.Height = btnOK.Top + btnOK.Height + (Me.Height - Me.ClientRectangle.Height) + 10
            matched = True
        End If
        If Not matched Then
            MsgBox("新用户，请先录入信息")
            PreInputID = tbID.Text.Trim
            mdiMain.新增客户ToolStripMenuItem.PerformClick()
            Me.Close()
            Exit Sub
        End If
        xmlDoc.Load(envPath & "RECORD_" & tbID.Text.Trim & ".XML")
        Dim xmlEle As Xml.XmlElement
        For i = 0 To xmlDoc.SelectSingleNode("Record").SelectNodes("item").Count - 1
            xmlEle = xmlDoc.SelectSingleNode("Record").SelectNodes("item")(i)
            If xmlEle.GetAttribute("status") = "0" Then
                unReturn += 1
            End If
        Next
        If unReturn > 0 Then
            lbReturnStatus.Text = "还有" & unReturn & "条未归还记录"
            lbReturnStatus.ForeColor = Color.Red
        Else
            lbReturnStatus.Text = "无未归还记录"
            lbReturnStatus.ForeColor = Color.Green
        End If
        GroupBox1.Visible = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim xmlDoc2 As New Xml.XmlDocument
        Dim xmlEle As Xml.XmlElement
        Dim xmlEle2 As Xml.XmlElement
        xmlDoc2.Load(envPath & "RECORD_" & tbID.Text.Trim & ".XML")
        xmlEle = xmlDoc2.SelectSingleNode("Record")
        xmlEle2 = xmlDoc2.CreateElement("item")
        xmlEle2.AppendChild(xmlDoc2.CreateCDataSection(tbNote.Text))
        xmlEle2.SetAttribute("model", tbModel.Text.Trim)
        xmlEle2.SetAttribute("cid", tbCardNumber.Text.Trim)
        xmlEle2.SetAttribute("rentdate", tbRentTime.Text.Trim)
        xmlEle2.SetAttribute("status", "0")
        xmlEle2.SetAttribute("readbefore", tbRead.Text.Trim)
        xmlEle.AppendChild(xmlEle2)
        xmlDoc2.Save(envPath & "RECORD_" & tbID.Text.Trim & ".XML")
        Me.Close()
    End Sub

    Private Sub btnHis_Click(sender As Object, e As EventArgs) Handles btnHis.Click
        Dim frmNew As New frmRECORDViewer
        LoadRecord = "RECORD_" & tbID.Text.Trim & ".XML"
        frmNew.MdiParent = mdiMain
        frmNew.Show()
    End Sub


    Private Sub tbID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnComfirm.PerformClick()
        End If
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class