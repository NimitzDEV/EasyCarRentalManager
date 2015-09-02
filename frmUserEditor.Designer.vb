<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserEditor
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbID = New System.Windows.Forms.Label()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSex = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHis = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(71, 18)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(65, 12)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "身份证号码"
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(71, 318)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbNote.Size = New System.Drawing.Size(273, 83)
        Me.tbNote.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "备注"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(71, 218)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAddress.Size = New System.Drawing.Size(273, 83)
        Me.tbAddress.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "联系地址"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(87, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 11)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "*两个号码必须填写其中一个"
        '
        'tbDial
        '
        Me.tbDial.Location = New System.Drawing.Point(71, 146)
        Me.tbDial.Name = "tbDial"
        Me.tbDial.Size = New System.Drawing.Size(159, 21)
        Me.tbDial.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "固定电话"
        '
        'tbPhoneNumber
        '
        Me.tbPhoneNumber.Location = New System.Drawing.Point(71, 119)
        Me.tbPhoneNumber.Name = "tbPhoneNumber"
        Me.tbPhoneNumber.Size = New System.Drawing.Size(159, 21)
        Me.tbPhoneNumber.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "手机号码"
        '
        'cbSex
        '
        Me.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.Items.AddRange(New Object() {"男", "女"})
        Me.cbSex.Location = New System.Drawing.Point(71, 74)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(42, 20)
        Me.cbSex.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "性别"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(71, 47)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(159, 21)
        Me.tbName.TabIndex = 17
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(12, 50)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(53, 12)
        Me.lbName.TabIndex = 15
        Me.lbName.Text = "客户姓名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "身份证号"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 412)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.Text = "编辑信息"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHis
        '
        Me.btnHis.Location = New System.Drawing.Point(93, 412)
        Me.btnHis.Name = "btnHis"
        Me.btnHis.Size = New System.Drawing.Size(143, 23)
        Me.btnHis.TabIndex = 30
        Me.btnHis.Text = "查看客户历史租车记录"
        Me.btnHis.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Red
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(257, 412)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(87, 23)
        Me.btnDel.TabIndex = 31
        Me.btnDel.Text = "删除此用户"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'frmUserEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 444)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnHis)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSex)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmUserEditor"
        Me.Text = "用户信息管理/编辑/查看"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbID As Label
    Friend WithEvents tbNote As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHis As Button
    Friend WithEvents btnDel As Button
End Class
