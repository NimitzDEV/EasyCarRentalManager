Public Class frmUserEditor
    Dim mirUserID As String = LoadUserID
    Dim mirCanBeE As Boolean = CanBeEdit
    Dim isMatched As Boolean = False
    Dim xmlDoc As New Xml.XmlDocument
    Dim writeKey() As String = {"name", "sex", "phone", "dial", "addr", "note"}
    Dim writeSouce() As Object
    Private Sub frmUserEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Enabled = mirCanBeE
        btnDel.Enabled = mirCanBeE
        '加载用户信息
        Dim xmlUser As Xml.XmlElement = getUser(mirUserID)
        '读取数据
        If isMatched Then
            lbID.Text = xmlUser.SelectSingleNode("id").InnerText
            tbName.Text = xmlUser.SelectSingleNode("name").InnerText
            cbSex.SelectedIndex = xmlUser.SelectSingleNode("sex").InnerText
            tbPhoneNumber.Text = xmlUser.SelectSingleNode("phone").InnerText
            tbDial.Text = xmlUser.SelectSingleNode("dial").InnerText
            tbAddress.Text = xmlUser.SelectSingleNode("addr").InnerText
            tbNote.Text = xmlUser.SelectSingleNode("note").InnerText
        End If
        setEditable(False)
    End Sub

    Private Sub setEditable(Optional ByVal editable As Boolean = False)
        For Each ctrs In Controls
            If ctrs.GetType().ToString = "System.Windows.Forms.TextBox" Then
                ctrs.ReadOnly = Not editable
            End If
        Next
        cbSex.Enabled = editable
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "编辑信息" Then
            setEditable(True）
            btnEdit.Text = "保存"
        ElseIf btnEdit.Text = "保存" Then
            setEditable(False)
            saveXml()
            btnEdit.Text = "编辑信息"
        End If
    End Sub

    Private Sub btnHis_Click(sender As Object, e As EventArgs) Handles btnHis.Click
        LoadRecord = "RECORD_" & lbID.Text & ".XML"
        frmRECORDViewer.ShowDialog()
        frmRECORDViewer.Dispose()
    End Sub

    Private Function getUser(ByVal id As String) As Xml.XmlElement
        xmlDoc.Load(envPath & "Users.xml")
        Dim xmlUser As Xml.XmlElement = Nothing
        '搜索数据
        For i = 0 To xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User").Count - 1
            xmlUser = xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User")(i)
            If xmlUser.SelectSingleNode("id").InnerText = mirUserID Then
                isMatched = True
                Exit For
            End If
        Next
        Return xmlUser
    End Function

    Private Sub saveXml()
        '验证
        If tbName.Text.Trim = "" Or
                cbSex.SelectedIndex = -1 Or tbAddress.Text.Trim = "" Then
            MsgBox("客户信息不全")
            Exit Sub
            '电话号码
            If tbPhoneNumber.Text.Trim = "" And tbDial.Text.Trim = "" Then
                MsgBox("必须预留其中一个联系号码")
                Exit Sub
            End If
        End If
        '修改数据
        Dim xmlEle As Xml.XmlElement
        xmlEle = getUser(lbID.Text)
        writeSouce = {tbName.Text, cbSex.SelectedIndex, tbPhoneNumber.Text, tbDial.Text, tbAddress.Text, tbNote.Text}
        Dim CDATA As Xml.XmlCDataSection
        For i = 0 To writeKey.Count - 1
            CDATA = xmlDoc.CreateCDataSection(writeSouce(i))
            xmlEle.SelectSingleNode(writeKey(i)).InnerText = ""
            xmlEle.SelectSingleNode(writeKey(i)).AppendChild(CDATA)
        Next
        xmlDoc.Save(envPath & "Users.xml")
    End Sub

    Private Sub frmUserEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnEdit.Text = "保存" Then
            If MsgBox("不保存吗？", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = -1
            End If
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If MsgBox("确认删除此用户吗？", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim xmlEle As Xml.XmlElement = getUser(lbID.Text)
            xmlDoc.SelectSingleNode("UserInfo").RemoveChild(xmlEle)
            xmlDoc.Save(envPath & "Users.xml")
            btnEdit.Text = "编辑信息"
            Close()
        End If
    End Sub
End Class