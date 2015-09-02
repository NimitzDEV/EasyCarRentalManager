<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.系统ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.客户ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增客户ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.客户管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.统计信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.租还ZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出租ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.归还ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.查看所有记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tslTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslGC = New System.Windows.Forms.ToolStripLabel()
        Me.tmrTimeNow = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.系统ToolStripMenuItem, Me.客户ToolStripMenuItem, Me.租还ZToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(765, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        '系统ToolStripMenuItem
        '
        Me.系统ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出ToolStripMenuItem, Me.ToolStripMenuItem2, Me.关于ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem"
        Me.系统ToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.系统ToolStripMenuItem.Text = "系统(&X)"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.退出ToolStripMenuItem.Text = "退出(&T)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 6)
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '客户ToolStripMenuItem
        '
        Me.客户ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增客户ToolStripMenuItem, Me.客户管理ToolStripMenuItem, Me.统计信息ToolStripMenuItem})
        Me.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem"
        Me.客户ToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.客户ToolStripMenuItem.Text = "客户(&K)"
        '
        '新增客户ToolStripMenuItem
        '
        Me.新增客户ToolStripMenuItem.Name = "新增客户ToolStripMenuItem"
        Me.新增客户ToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.新增客户ToolStripMenuItem.Text = "新增客户(&X)"
        '
        '客户管理ToolStripMenuItem
        '
        Me.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem"
        Me.客户管理ToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.客户管理ToolStripMenuItem.Text = "客户管理(&G)"
        '
        '统计信息ToolStripMenuItem
        '
        Me.统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem"
        Me.统计信息ToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.统计信息ToolStripMenuItem.Text = "统计信息(&T)"
        '
        '租还ZToolStripMenuItem
        '
        Me.租还ZToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.出租ToolStripMenuItem, Me.归还ToolStripMenuItem, Me.ToolStripMenuItem1, Me.查看所有记录ToolStripMenuItem})
        Me.租还ZToolStripMenuItem.Name = "租还ZToolStripMenuItem"
        Me.租还ZToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.租还ZToolStripMenuItem.Text = "租还(&Z)"
        '
        '出租ToolStripMenuItem
        '
        Me.出租ToolStripMenuItem.Name = "出租ToolStripMenuItem"
        Me.出租ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.出租ToolStripMenuItem.Text = "出租(&C)"
        '
        '归还ToolStripMenuItem
        '
        Me.归还ToolStripMenuItem.Name = "归还ToolStripMenuItem"
        Me.归还ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.归还ToolStripMenuItem.Text = "归还(&G)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 6)
        '
        '查看所有记录ToolStripMenuItem
        '
        Me.查看所有记录ToolStripMenuItem.Name = "查看所有记录ToolStripMenuItem"
        Me.查看所有记录ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.查看所有记录ToolStripMenuItem.Text = "查看所有记录(&J)"
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslTime, Me.ToolStripSeparator1, Me.tslGC})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 455)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(765, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tslTime
        '
        Me.tslTime.Name = "tslTime"
        Me.tslTime.Size = New System.Drawing.Size(44, 22)
        Me.tslTime.Text = "--:--:--"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslGC
        '
        Me.tslGC.Name = "tslGC"
        Me.tslGC.Size = New System.Drawing.Size(80, 22)
        Me.tslGC.Text = "执行内存回收"
        '
        'tmrTimeNow
        '
        Me.tmrTimeNow.Enabled = True
        Me.tmrTimeNow.Interval = 1000
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 480)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiMain"
        Me.Text = "mdiMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents 系统ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents tslTime As ToolStripLabel
    Friend WithEvents tmrTimeNow As Timer
    Friend WithEvents 客户ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新增客户ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 客户管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 统计信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 租还ZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 出租ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 归还ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 查看所有记录ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tslGC As ToolStripLabel
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
End Class
