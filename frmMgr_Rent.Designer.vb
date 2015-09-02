<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMgr_Rent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbRead = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCardNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbRentTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHis = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbReturnStatus = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.gbDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "输入身份证号码"
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbID.Location = New System.Drawing.Point(107, 10)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(327, 29)
        Me.tbID.TabIndex = 1
        Me.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnComfirm
        '
        Me.btnComfirm.Location = New System.Drawing.Point(440, 8)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(75, 31)
        Me.btnComfirm.TabIndex = 2
        Me.btnComfirm.Text = "确认"
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.tbNote)
        Me.gbDetails.Controls.Add(Me.Label6)
        Me.gbDetails.Controls.Add(Me.tbRead)
        Me.gbDetails.Controls.Add(Me.Label5)
        Me.gbDetails.Controls.Add(Me.tbCardNumber)
        Me.gbDetails.Controls.Add(Me.Label4)
        Me.gbDetails.Controls.Add(Me.tbModel)
        Me.gbDetails.Controls.Add(Me.Label3)
        Me.gbDetails.Controls.Add(Me.tbRentTime)
        Me.gbDetails.Controls.Add(Me.Label2)
        Me.gbDetails.Location = New System.Drawing.Point(14, 127)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(501, 145)
        Me.gbDetails.TabIndex = 3
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "租车详细"
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(74, 103)
        Me.tbNote.Name = "tbNote"
        Me.tbNote.Size = New System.Drawing.Size(390, 21)
        Me.tbNote.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "备注"
        '
        'tbRead
        '
        Me.tbRead.Location = New System.Drawing.Point(366, 22)
        Me.tbRead.Name = "tbRead"
        Me.tbRead.Size = New System.Drawing.Size(98, 21)
        Me.tbRead.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "里程表读数"
        '
        'tbCardNumber
        '
        Me.tbCardNumber.Location = New System.Drawing.Point(74, 76)
        Me.tbCardNumber.Name = "tbCardNumber"
        Me.tbCardNumber.Size = New System.Drawing.Size(197, 21)
        Me.tbCardNumber.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "车牌号"
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(74, 49)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(197, 21)
        Me.tbModel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "车型号"
        '
        'tbRentTime
        '
        Me.tbRentTime.Location = New System.Drawing.Point(74, 22)
        Me.tbRentTime.Name = "tbRentTime"
        Me.tbRentTime.ReadOnly = True
        Me.tbRentTime.Size = New System.Drawing.Size(197, 21)
        Me.tbRentTime.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "租出时间"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(14, 278)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(420, 38)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "确认租出"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(440, 278)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHis
        '
        Me.btnHis.Location = New System.Drawing.Point(335, 35)
        Me.btnHis.Name = "btnHis"
        Me.btnHis.Size = New System.Drawing.Size(151, 23)
        Me.btnHis.TabIndex = 6
        Me.btnHis.Text = "查看此客户的租车记录"
        Me.btnHis.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbReturnStatus)
        Me.GroupBox1.Controls.Add(Me.lbUserName)
        Me.GroupBox1.Controls.Add(Me.btnHis)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 64)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "客户信息"
        Me.GroupBox1.Visible = False
        '
        'lbReturnStatus
        '
        Me.lbReturnStatus.AutoSize = True
        Me.lbReturnStatus.Location = New System.Drawing.Point(333, 20)
        Me.lbReturnStatus.Name = "lbReturnStatus"
        Me.lbReturnStatus.Size = New System.Drawing.Size(77, 12)
        Me.lbReturnStatus.TabIndex = 7
        Me.lbReturnStatus.Text = "无未归还历史"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Location = New System.Drawing.Point(15, 20)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(65, 12)
        Me.lbUserName.TabIndex = 0
        Me.lbUserName.Text = "用户姓名："
        '
        'frmMgr_Rent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.gbDetails)
        Me.Controls.Add(Me.btnComfirm)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMgr_Rent"
        Me.Text = "添加出租记录"
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents btnComfirm As Button
    Friend WithEvents gbDetails As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbRentTime As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tbModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCardNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbRead As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tbNote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHis As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbUserName As Label
    Friend WithEvents lbReturnStatus As Label
End Class
