<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustoms_New
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
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSex = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.tbDial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbRantNow = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(21, 48)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(53, 12)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "客户姓名"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(80, 45)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(159, 21)
        Me.tbName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "性别"
        '
        'cbSex
        '
        Me.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.Items.AddRange(New Object() {"男", "女"})
        Me.cbSex.Location = New System.Drawing.Point(80, 72)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(42, 20)
        Me.cbSex.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "身份证号"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(80, 18)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(159, 21)
        Me.tbID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "手机号码"
        '
        'tbPhoneNumber
        '
        Me.tbPhoneNumber.Location = New System.Drawing.Point(80, 117)
        Me.tbPhoneNumber.Name = "tbPhoneNumber"
        Me.tbPhoneNumber.Size = New System.Drawing.Size(159, 21)
        Me.tbPhoneNumber.TabIndex = 4
        '
        'tbDial
        '
        Me.tbDial.Location = New System.Drawing.Point(80, 144)
        Me.tbDial.Name = "tbDial"
        Me.tbDial.Size = New System.Drawing.Size(159, 21)
        Me.tbDial.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "固定电话"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(96, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 11)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "*两个号码必须填写其中一个"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(80, 216)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAddress.Size = New System.Drawing.Size(273, 83)
        Me.tbAddress.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "联系地址"
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(80, 316)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbNote.Size = New System.Drawing.Size(273, 83)
        Me.tbNote.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "备注"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(197, 427)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "确认添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cbRantNow
        '
        Me.cbRantNow.AutoSize = True
        Me.cbRantNow.Checked = True
        Me.cbRantNow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbRantNow.Location = New System.Drawing.Point(199, 456)
        Me.cbRantNow.Name = "cbRantNow"
        Me.cbRantNow.Size = New System.Drawing.Size(156, 16)
        Me.cbRantNow.TabIndex = 9
        Me.cbRantNow.Text = "添加后立即添加租车记录"
        Me.cbRantNow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(278, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(245, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "身份证号不可更改"
        '
        'frmCustoms_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 486)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbRantNow)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbNote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbSex)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCustoms_New"
        Me.Text = "新增客户"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPhoneNumber As TextBox
    Friend WithEvents tbDial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNote As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbRantNow As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
End Class
