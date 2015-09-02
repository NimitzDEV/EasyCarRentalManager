Public Class frmCustoms_Index
    Private Sub frmCustoms_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.Load(envPath & "Users.xml")
        lbCustomCount.Text = "客户总数：" & xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User").Count
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        updateRecords()
        btnShow.Visible = False
        lbTotal.Text = "总租出数：" & allRecords.Count
        lbRe.Text = "未归还数：" & (From u In allRecords Where u.status = "0" Select u).Count
    End Sub
End Class