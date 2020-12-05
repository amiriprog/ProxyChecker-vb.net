<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProxyChecker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.Btn_Path = New System.Windows.Forms.Button()
        Me.Badlabel = New System.Windows.Forms.Label()
        Me.goodlabel = New System.Windows.Forms.Label()
        Me.TxtGood = New System.Windows.Forms.TextBox()
        Me.TxtBad = New System.Windows.Forms.TextBox()
        Me.TimeoutCount = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Socks_ThreadsCount = New System.Windows.Forms.NumericUpDown()
        Me.Lbl_All = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.TimeoutCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Socks_ThreadsCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Start
        '
        Me.Btn_Start.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Start.Location = New System.Drawing.Point(315, 41)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(130, 36)
        Me.Btn_Start.TabIndex = 3
        Me.Btn_Start.Text = "Start Check"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'TxtPath
        '
        Me.TxtPath.BackColor = System.Drawing.Color.White
        Me.TxtPath.Location = New System.Drawing.Point(6, 14)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.ReadOnly = True
        Me.TxtPath.Size = New System.Drawing.Size(405, 20)
        Me.TxtPath.TabIndex = 4
        '
        'Btn_Path
        '
        Me.Btn_Path.Location = New System.Drawing.Point(417, 11)
        Me.Btn_Path.Name = "Btn_Path"
        Me.Btn_Path.Size = New System.Drawing.Size(27, 23)
        Me.Btn_Path.TabIndex = 5
        Me.Btn_Path.Text = "..."
        Me.Btn_Path.UseVisualStyleBackColor = True
        '
        'Badlabel
        '
        Me.Badlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Badlabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badlabel.ForeColor = System.Drawing.Color.Red
        Me.Badlabel.Location = New System.Drawing.Point(234, 597)
        Me.Badlabel.Name = "Badlabel"
        Me.Badlabel.Size = New System.Drawing.Size(216, 19)
        Me.Badlabel.TabIndex = 6
        Me.Badlabel.Text = "0"
        Me.Badlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'goodlabel
        '
        Me.goodlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.goodlabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goodlabel.ForeColor = System.Drawing.Color.Green
        Me.goodlabel.Location = New System.Drawing.Point(12, 597)
        Me.goodlabel.Name = "goodlabel"
        Me.goodlabel.Size = New System.Drawing.Size(216, 19)
        Me.goodlabel.TabIndex = 7
        Me.goodlabel.Text = "0"
        Me.goodlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtGood
        '
        Me.TxtGood.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtGood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGood.ForeColor = System.Drawing.Color.Green
        Me.TxtGood.Location = New System.Drawing.Point(11, 97)
        Me.TxtGood.Multiline = True
        Me.TxtGood.Name = "TxtGood"
        Me.TxtGood.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtGood.Size = New System.Drawing.Size(216, 498)
        Me.TxtGood.TabIndex = 10
        '
        'TxtBad
        '
        Me.TxtBad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBad.ForeColor = System.Drawing.Color.Red
        Me.TxtBad.Location = New System.Drawing.Point(233, 97)
        Me.TxtBad.Multiline = True
        Me.TxtBad.Name = "TxtBad"
        Me.TxtBad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBad.Size = New System.Drawing.Size(221, 498)
        Me.TxtBad.TabIndex = 11
        '
        'TimeoutCount
        '
        Me.TimeoutCount.BackColor = System.Drawing.Color.White
        Me.TimeoutCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeoutCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeoutCount.ForeColor = System.Drawing.Color.Black
        Me.TimeoutCount.Location = New System.Drawing.Point(95, 56)
        Me.TimeoutCount.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.TimeoutCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeoutCount.Name = "TimeoutCount"
        Me.TimeoutCount.Size = New System.Drawing.Size(69, 21)
        Me.TimeoutCount.TabIndex = 154
        Me.TimeoutCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimeoutCount.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 41)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "Threads:"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(92, 41)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 155
        Me.Label18.Text = "TimeOut:"
        '
        'Socks_ThreadsCount
        '
        Me.Socks_ThreadsCount.BackColor = System.Drawing.Color.White
        Me.Socks_ThreadsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Socks_ThreadsCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Socks_ThreadsCount.ForeColor = System.Drawing.Color.Black
        Me.Socks_ThreadsCount.Location = New System.Drawing.Point(16, 56)
        Me.Socks_ThreadsCount.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.Socks_ThreadsCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Socks_ThreadsCount.Name = "Socks_ThreadsCount"
        Me.Socks_ThreadsCount.Size = New System.Drawing.Size(69, 21)
        Me.Socks_ThreadsCount.TabIndex = 152
        Me.Socks_ThreadsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Socks_ThreadsCount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Lbl_All
        '
        Me.Lbl_All.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_All.Location = New System.Drawing.Point(16, 54)
        Me.Lbl_All.Name = "Lbl_All"
        Me.Lbl_All.Size = New System.Drawing.Size(293, 13)
        Me.Lbl_All.TabIndex = 156
        Me.Lbl_All.Text = "0"
        Me.Lbl_All.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 537)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtPath)
        Me.GroupBox2.Controls.Add(Me.Btn_Start)
        Me.GroupBox2.Controls.Add(Me.TimeoutCount)
        Me.GroupBox2.Controls.Add(Me.Btn_Path)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Socks_ThreadsCount)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Lbl_All)
        Me.GroupBox2.Location = New System.Drawing.Point(6, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 86)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        '
        'ProxyChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 626)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtBad)
        Me.Controls.Add(Me.TxtGood)
        Me.Controls.Add(Me.goodlabel)
        Me.Controls.Add(Me.Badlabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(478, 664)
        Me.MinimumSize = New System.Drawing.Size(478, 664)
        Me.Name = "ProxyChecker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proxy Checker"
        CType(Me.TimeoutCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Socks_ThreadsCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Start As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Path As System.Windows.Forms.Button
    Friend WithEvents Badlabel As System.Windows.Forms.Label
    Friend WithEvents goodlabel As System.Windows.Forms.Label
    Friend WithEvents TxtGood As System.Windows.Forms.TextBox
    Friend WithEvents TxtBad As System.Windows.Forms.TextBox
    Friend WithEvents TimeoutCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Socks_ThreadsCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_All As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
