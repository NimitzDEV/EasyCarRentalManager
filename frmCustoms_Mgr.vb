Public Class frmCustoms_Mgr
    Public Class customersInfo
        Public Property id As String
        Public Property name As String
        Public Property sex As String
        Public Property phone As String
        Public Property dial As String
        Public Property addr As String
        Public Property note As String
    End Class
    Dim customers As New List(Of customersInfo)
    Dim filtered As New List(Of customersInfo)
    Private Sub frmCustoms_Mgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        freshList(customers)
    End Sub

    Private Sub LoadData()
        customers.Clear()
        Try
            Dim xmlDoc As New Xml.XmlDocument
            Dim xmlEle As Xml.XmlElement
            xmlDoc.Load(envPath & "Users.xml")
            For i = 0 To xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User").Count - 1
                xmlEle = xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User")(i)
                Dim uinfo As New customersInfo
                uinfo.id = xmlEle.SelectSingleNode("id").InnerText
                uinfo.name = xmlEle.SelectSingleNode("name").InnerText
                uinfo.note = xmlEle.SelectSingleNode("note").InnerText
                uinfo.phone = xmlEle.SelectSingleNode("phone").InnerText
                uinfo.sex = xmlEle.SelectSingleNode("sex").InnerText
                uinfo.sex = IIf(uinfo.sex = "0", "男", "女")
                uinfo.dial = xmlEle.SelectSingleNode("dial").InnerText
                uinfo.addr = xmlEle.SelectSingleNode("addr").InnerText
                customers.Add(uinfo)
                Application.DoEvents()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub freshList(ByRef searchIn As List(Of customersInfo))
        lvAll.Items.Clear()
        For Each uinfo In searchIn
            Dim u As New ListViewItem
            u.Text = uinfo.id
            u.SubItems.Add(uinfo.name)
            u.SubItems.Add(uinfo.sex)
            u.SubItems.Add(uinfo.dial)
            u.SubItems.Add(uinfo.phone)
            u.SubItems.Add(uinfo.addr)
            lvAll.Items.Add(u)
            Application.DoEvents()
        Next
    End Sub

    Private Sub cbFilter_CheckedChanged(sender As Object, e As EventArgs) Handles cbFilter.CheckedChanged
        If cbFilter.Checked Then
            gbFilter.Enabled = True
        Else
            gbFilter.Enabled = False
            freshList(customers)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        filtered.Clear()
        If tbAddr.Text.Trim <> "" Then
            filtered = (From u In customers Where u.addr.Contains(tbAddr.Text.Trim) Select u).ToList
        End If
        If tbID.Text.Trim <> "" Then
            filtered = (From u In customers Where u.id.Contains(tbID.Text.Trim) Select u).ToList
        End If
        If tbName.Text.Trim <> "" Then
            filtered = (From u In customers Where u.name.Contains(tbName.Text.Trim) Select u).ToList
        End If
        If tbPhone.Text.Trim <> "" Then
            filtered = (From u In customers Where u.phone.Contains(tbPhone.Text.Trim) Or u.dial.Contains(tbPhone.Text.Trim) Select u).ToList
        End If
        freshList(filtered)
    End Sub

    Private Sub lvAll_DoubleClick(sender As Object, e As EventArgs) Handles lvAll.DoubleClick
        If lvAll.SelectedItems.Count = 0 Then Exit Sub
        LoadUserID = lvAll.SelectedItems(0).Text
        CanBeEdit = True
        frmUserEditor.ShowDialog()
        frmUserEditor.Dispose()
        LoadData()
        freshList(customers)
    End Sub

    Private Sub lvAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvAll.SelectedIndexChanged

    End Sub
End Class