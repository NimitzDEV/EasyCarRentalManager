Imports System.Windows.Forms

Public Class mdiMain

    Private Sub mdiMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("确认退出？", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = -1
            Exit Sub
        End If
        frmMain.Close()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Application.ProductName & " - " & Application.ProductVersion
        If showHelpIntro Then
            Dim frmNew As New frmHelp
            frmNew.MdiParent = Me
            frmNew.Show()
        End If
    End Sub

    Private Sub tmrTimeNow_Tick(sender As Object, e As EventArgs) Handles tmrTimeNow.Tick
        tslTime.Text = DateTime.Now
    End Sub

    Private Sub 新增客户ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增客户ToolStripMenuItem.Click
        Dim frmNew As New frmCustoms_New
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub 客户管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 客户管理ToolStripMenuItem.Click
        frmCustoms_Mgr.ShowDialog()
        frmCustoms_Mgr.Dispose()
    End Sub

    Private Sub 出租ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 出租ToolStripMenuItem.Click
        Dim frmRent As New frmMgr_Rent
        frmRent.MdiParent = Me
        frmRent.Show()
    End Sub

    Private Sub tslGC_Click(sender As Object, e As EventArgs) Handles tslGC.Click
        GC.Collect()
        tslGC.Text = "执行内存回收（" & GC.GetTotalMemory(False) & "）"
    End Sub

    Private Sub 统计信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 统计信息ToolStripMenuItem.Click
        frmCustoms_Index.ShowDialog()
        frmCustoms_Index.Dispose()
    End Sub

    Private Sub 归还ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 归还ToolStripMenuItem.Click
        Dim frmNew As New frmMgr_Return
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        frmAbout.ShowDialog()
        frmAbout.Dispose()
    End Sub

    Private Sub 查看所有记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查看所有记录ToolStripMenuItem.Click
        updateRecords()
        Dim frmNew As New frmAllRecords
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

    Private Sub 帮助ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 帮助ToolStripMenuItem.Click
        Dim frmNew As New frmHelp
        frmNew.MdiParent = Me
        frmNew.Show()
    End Sub

End Class
