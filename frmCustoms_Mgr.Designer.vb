<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustoms_Mgr
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
        Me.lvAll = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbFilter = New System.Windows.Forms.CheckBox()
        Me.gbFilter = New System.Windows.Forms.GroupBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.tbAddr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvAll
        '
        Me.lvAll.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvAll.FullRowSelect = True
        Me.lvAll.Location = New System.Drawing.Point(12, 12)
        Me.lvAll.MultiSelect = False
        Me.lvAll.Name = "lvAll"
        Me.lvAll.Size = New System.Drawing.Size(908, 469)
        Me.lvAll.TabIndex = 0
        Me.lvAll.UseCompatibleStateImageBehavior = False
        Me.lvAll.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "身份证号码"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "客户姓名"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "性别"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "固定电话"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "手机号码"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "联系地址"
        Me.ColumnHeader6.Width = 300
        '
        'cbFilter
        '
        Me.cbFilter.AutoSize = True
        Me.cbFilter.Location = New System.Drawing.Point(12, 487)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(72, 16)
        Me.cbFilter.TabIndex = 1
        Me.cbFilter.Text = "数据筛选"
        Me.cbFilter.UseVisualStyleBackColor = True
        '
        'gbFilter
        '
        Me.gbFilter.Controls.Add(Me.btnFilter)
        Me.gbFilter.Controls.Add(Me.tbAddr)
        Me.gbFilter.Controls.Add(Me.Label4)
        Me.gbFilter.Controls.Add(Me.tbPhone)
        Me.gbFilter.Controls.Add(Me.Label3)
        Me.gbFilter.Controls.Add(Me.tbName)
        Me.gbFilter.Controls.Add(Me.Label2)
        Me.gbFilter.Controls.Add(Me.tbID)
        Me.gbFilter.Controls.Add(Me.Label1)
        Me.gbFilter.Enabled = False
        Me.gbFilter.Location = New System.Drawing.Point(12, 509)
        Me.gbFilter.Name = "gbFilter"
        Me.gbFilter.Size = New System.Drawing.Size(629, 90)
        Me.gbFilter.TabIndex = 2
        Me.gbFilter.TabStop = False
        Me.gbFilter.Text = "筛选条件"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(534, 55)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 8
        Me.btnFilter.Text = "开始筛选"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'tbAddr
        '
        Me.tbAddr.Location = New System.Drawing.Point(330, 57)
        Me.tbAddr.Name = "tbAddr"
        Me.tbAddr.Size = New System.Drawing.Size(185, 21)
        Me.tbAddr.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "联系地址"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(66, 57)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(185, 21)
        Me.tbPhone.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "号码"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(330, 20)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(185, 21)
        Me.tbName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "客户姓名"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(66, 20)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(185, 21)
        Me.tbID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "身份证号"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(647, 564)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "打开数据筛选进行筛选，取消勾选则关闭筛选"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(647, 584)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "双击条目进行管理"
        '
        'frmCustoms_Mgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 602)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbFilter)
        Me.Controls.Add(Me.cbFilter)
        Me.Controls.Add(Me.lvAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCustoms_Mgr"
        Me.Text = "客户管理"
        Me.gbFilter.ResumeLayout(False)
        Me.gbFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvAll As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents cbFilter As CheckBox
    Friend WithEvents gbFilter As GroupBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAddr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
