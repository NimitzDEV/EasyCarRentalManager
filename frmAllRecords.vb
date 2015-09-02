Public Class frmAllRecords
    Private Sub frmAllRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        loadList(allRecords)
    End Sub

    Private Sub loadList(ByVal required As List(Of RecordInfo))
        lvRecords.Items.Clear()
        For i = 0 To required.Count - 1
            Dim u As New ListViewItem
            With required(i)
                u.Text = .rentByUserName & " | " & .rentByUserID
                u.SubItems.Add(.model)
                u.SubItems.Add(.cid)
                u.SubItems.Add(.rentDate)
                u.SubItems.Add(.readBefore)
                u.SubItems.Add(IIf(.status = "0", "未归还", .returnDate))
                u.SubItems.Add(.readAfter)
                u.SubItems.Add(.note)
                If .status = "0" Then u.BackColor = Color.OrangeRed
                lvRecords.Items.Add(u)
                Application.DoEvents()
            End With
        Next
    End Sub
End Class