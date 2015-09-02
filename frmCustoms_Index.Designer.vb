<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustoms_Index
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbCustomCount = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbRe = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbCustomCount
        '
        Me.lbCustomCount.AutoSize = True
        Me.lbCustomCount.Location = New System.Drawing.Point(12, 9)
        Me.lbCustomCount.Name = "lbCustomCount"
        Me.lbCustomCount.Size = New System.Drawing.Size(53, 12)
        Me.lbCustomCount.TabIndex = 0
        Me.lbCustomCount.Text = "客户总数"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(12, 40)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(53, 12)
        Me.lbTotal.TabIndex = 1
        Me.lbTotal.Text = "总租出数"
        '
        'lbRe
        '
        Me.lbRe.AutoSize = True
        Me.lbRe.Location = New System.Drawing.Point(12, 61)
        Me.lbRe.Name = "lbRe"
        Me.lbRe.Size = New System.Drawing.Size(53, 12)
        Me.lbRe.TabIndex = 2
        Me.lbRe.Text = "未归还数"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(71, 40)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 33)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "统计"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmCustoms_Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 97)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lbRe)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lbCustomCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCustoms_Index"
        Me.Text = "客户 - 统计信息"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCustomCount As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbRe As Label
    Friend WithEvents btnShow As Button
End Class
