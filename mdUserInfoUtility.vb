Module mdUserInfoUtility
    Public Class RecordInfo
        Public Property rentByUserID As String
        Public Property rentByUserName As String
        Public Property model As String
        Public Property cid As String
        Public Property rentDate As String
        Public Property returnDate As String
        Public Property status As String
        Public Property readBefore As String
        Public Property readAfter As String
        Public Property note As String
    End Class
    Public allRecords As New List(Of RecordInfo)
    Public Sub updateRecords()
        frmStaticsUpdater.ShowDialog()
        frmStaticsUpdater.Dispose()
    End Sub
End Module
