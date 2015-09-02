<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMgr_Return
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
        Me.components = New System.ComponentModel.Container()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lvUnreturn = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRead = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbReturnDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnComfirm
        '
        Me.btnComfirm.Location = New System.Drawing.Point(440, 4)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(75, 29)
        Me.btnComfirm.TabIndex = 5
        Me.btnComfirm.Text = "确认"
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("宋体", 14.25!)
        Me.tbID.Location = New System.Drawing.Point(107, 4)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(327, 29)
        Me.tbID.TabIndex = 4
        Me.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "输入身份证号码"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbUserName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 62)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "用户信息"
        Me.GroupBox1.Visible = False
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Location = New System.Drawing.Point(15, 28)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(65, 12)
        Me.lbUserName.TabIndex = 0
        Me.lbUserName.Text = "客户姓名："
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(12, 418)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(420, 35)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "归还此记录"
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'lvUnreturn
        '
        Me.lvUnreturn.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvUnreturn.FullRowSelect = True
        Me.lvUnreturn.Location = New System.Drawing.Point(12, 107)
        Me.lvUnreturn.MultiSelect = False
        Me.lvUnreturn.Name = "lvUnreturn"
        Me.lvUnreturn.Size = New System.Drawing.Size(501, 128)
        Me.lvUnreturn.TabIndex = 12
        Me.lvUnreturn.UseCompatibleStateImageBehavior = False
        Me.lvUnreturn.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "日期"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "型号"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "车牌号"
        Me.ColumnHeader2.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbNote)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tbRead)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tbReturnDate)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 171)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "归还登记"
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(75, 50)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbNote.Size = New System.Drawing.Size(419, 108)
        Me.tbNote.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "备注"
        '
        'tbRead
        '
        Me.tbRead.Location = New System.Drawing.Point(395, 19)
        Me.tbRead.Name = "tbRead"
        Me.tbRead.Size = New System.Drawing.Size(99, 21)
        Me.tbRead.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "里程表读数"
        '
        'tbReturnDate
        '
        Me.tbReturnDate.Location = New System.Drawing.Point(75, 19)
        Me.tbReturnDate.Name = "tbReturnDate"
        Me.tbReturnDate.ReadOnly = True
        Me.tbReturnDate.Size = New System.Drawing.Size(208, 21)
        Me.tbReturnDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "归还日期"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "关闭"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMgr_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 463)
        Me.Controls.Add(Me.lvUnreturn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnComfirm)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMgr_Return"
        Me.Text = "归还"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComfirm As Button
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbUserName As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents lvUnreturn As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbReturnDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents tbRead As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNote As TextBox
    Friend WithEvents Button1 As Button
End Class
