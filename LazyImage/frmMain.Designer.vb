<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbPictureNameList = New System.Windows.Forms.ListBox()
        Me.btnLoadPictures = New System.Windows.Forms.Button()
        Me.pbThumbnail = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFixedRatio = New System.Windows.Forms.CheckBox()
        Me.btnRecovery = New System.Windows.Forms.Button()
        Me.rbPercentage = New System.Windows.Forms.RadioButton()
        Me.rbPixel = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHorizontal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbVertical = New System.Windows.Forms.TextBox()
        Me.btnTransform = New System.Windows.Forms.Button()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpGenerate = New System.Windows.Forms.TabPage()
        Me.pbOriginal = New System.Windows.Forms.PictureBox()
        Me.lbPiturePathList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChoseDestFolder = New System.Windows.Forms.Button()
        Me.tbDestPath = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.tpCode = New System.Windows.Forms.TabPage()
        Me.tbFileNamePrefix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerateCode = New System.Windows.Forms.Button()
        Me.btnCopyCode = New System.Windows.Forms.Button()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsslMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslGithub = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.pbThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tpGenerate.SuspendLayout()
        CType(Me.pbOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCode.SuspendLayout()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPictureNameList
        '
        Me.lbPictureNameList.FormattingEnabled = True
        Me.lbPictureNameList.ItemHeight = 15
        Me.lbPictureNameList.Location = New System.Drawing.Point(8, 62)
        Me.lbPictureNameList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbPictureNameList.Name = "lbPictureNameList"
        Me.lbPictureNameList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbPictureNameList.Size = New System.Drawing.Size(159, 364)
        Me.lbPictureNameList.TabIndex = 0
        '
        'btnLoadPictures
        '
        Me.btnLoadPictures.Location = New System.Drawing.Point(8, 8)
        Me.btnLoadPictures.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLoadPictures.Name = "btnLoadPictures"
        Me.btnLoadPictures.Size = New System.Drawing.Size(100, 29)
        Me.btnLoadPictures.TabIndex = 1
        Me.btnLoadPictures.Text = "載入圖片"
        Me.btnLoadPictures.UseVisualStyleBackColor = True
        '
        'pbThumbnail
        '
        Me.pbThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbThumbnail.Location = New System.Drawing.Point(176, 44)
        Me.pbThumbnail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbThumbnail.Name = "pbThumbnail"
        Me.pbThumbnail.Size = New System.Drawing.Size(578, 587)
        Me.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbThumbnail.TabIndex = 2
        Me.pbThumbnail.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFixedRatio)
        Me.GroupBox1.Controls.Add(Me.btnRecovery)
        Me.GroupBox1.Controls.Add(Me.rbPercentage)
        Me.GroupBox1.Controls.Add(Me.rbPixel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbHorizontal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbVertical)
        Me.GroupBox1.Controls.Add(Me.btnTransform)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 435)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(160, 196)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "調整大小"
        '
        'cbFixedRatio
        '
        Me.cbFixedRatio.AutoSize = True
        Me.cbFixedRatio.Checked = True
        Me.cbFixedRatio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFixedRatio.Location = New System.Drawing.Point(8, 124)
        Me.cbFixedRatio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbFixedRatio.Name = "cbFixedRatio"
        Me.cbFixedRatio.Size = New System.Drawing.Size(104, 19)
        Me.cbFixedRatio.TabIndex = 13
        Me.cbFixedRatio.Text = "等比例縮放"
        Me.cbFixedRatio.UseVisualStyleBackColor = True
        '
        'btnRecovery
        '
        Me.btnRecovery.Location = New System.Drawing.Point(8, 151)
        Me.btnRecovery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRecovery.Name = "btnRecovery"
        Me.btnRecovery.Size = New System.Drawing.Size(67, 29)
        Me.btnRecovery.TabIndex = 12
        Me.btnRecovery.Text = "還原"
        Me.btnRecovery.UseVisualStyleBackColor = True
        '
        'rbPercentage
        '
        Me.rbPercentage.AutoSize = True
        Me.rbPercentage.Checked = True
        Me.rbPercentage.Location = New System.Drawing.Point(79, 26)
        Me.rbPercentage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbPercentage.Name = "rbPercentage"
        Me.rbPercentage.Size = New System.Drawing.Size(73, 19)
        Me.rbPercentage.TabIndex = 11
        Me.rbPercentage.TabStop = True
        Me.rbPercentage.Text = "百分比"
        Me.rbPercentage.UseVisualStyleBackColor = True
        '
        'rbPixel
        '
        Me.rbPixel.AutoSize = True
        Me.rbPixel.Location = New System.Drawing.Point(8, 26)
        Me.rbPixel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbPixel.Name = "rbPixel"
        Me.rbPixel.Size = New System.Drawing.Size(58, 19)
        Me.rbPixel.TabIndex = 10
        Me.rbPixel.Text = "像素"
        Me.rbPixel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "垂直"
        '
        'tbHorizontal
        '
        Me.tbHorizontal.Location = New System.Drawing.Point(55, 54)
        Me.tbHorizontal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbHorizontal.Name = "tbHorizontal"
        Me.tbHorizontal.Size = New System.Drawing.Size(65, 25)
        Me.tbHorizontal.TabIndex = 7
        Me.tbHorizontal.Text = "100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "水平"
        '
        'tbVertical
        '
        Me.tbVertical.Location = New System.Drawing.Point(55, 89)
        Me.tbVertical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbVertical.Name = "tbVertical"
        Me.tbVertical.Size = New System.Drawing.Size(65, 25)
        Me.tbVertical.TabIndex = 8
        Me.tbVertical.Text = "100"
        '
        'btnTransform
        '
        Me.btnTransform.Location = New System.Drawing.Point(85, 151)
        Me.btnTransform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTransform.Name = "btnTransform"
        Me.btnTransform.Size = New System.Drawing.Size(67, 29)
        Me.btnTransform.TabIndex = 0
        Me.btnTransform.Text = "轉換"
        Me.btnTransform.UseVisualStyleBackColor = True
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpGenerate)
        Me.tcMain.Controls.Add(Me.tpCode)
        Me.tcMain.Location = New System.Drawing.Point(0, 0)
        Me.tcMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(779, 671)
        Me.tcMain.TabIndex = 5
        '
        'tpGenerate
        '
        Me.tpGenerate.Controls.Add(Me.pbOriginal)
        Me.tpGenerate.Controls.Add(Me.lbPiturePathList)
        Me.tpGenerate.Controls.Add(Me.Label1)
        Me.tpGenerate.Controls.Add(Me.btnChoseDestFolder)
        Me.tpGenerate.Controls.Add(Me.tbDestPath)
        Me.tpGenerate.Controls.Add(Me.btnGenerate)
        Me.tpGenerate.Controls.Add(Me.GroupBox1)
        Me.tpGenerate.Controls.Add(Me.btnLoadPictures)
        Me.tpGenerate.Controls.Add(Me.lbPictureNameList)
        Me.tpGenerate.Controls.Add(Me.pbThumbnail)
        Me.tpGenerate.Location = New System.Drawing.Point(4, 25)
        Me.tpGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpGenerate.Name = "tpGenerate"
        Me.tpGenerate.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpGenerate.Size = New System.Drawing.Size(771, 642)
        Me.tpGenerate.TabIndex = 0
        Me.tpGenerate.Text = "*.pixel & *.color"
        Me.tpGenerate.UseVisualStyleBackColor = True
        '
        'pbOriginal
        '
        Me.pbOriginal.Location = New System.Drawing.Point(515, 384)
        Me.pbOriginal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbOriginal.Name = "pbOriginal"
        Me.pbOriginal.Size = New System.Drawing.Size(240, 248)
        Me.pbOriginal.TabIndex = 10
        Me.pbOriginal.TabStop = False
        Me.pbOriginal.Visible = False
        '
        'lbPiturePathList
        '
        Me.lbPiturePathList.FormattingEnabled = True
        Me.lbPiturePathList.ItemHeight = 15
        Me.lbPiturePathList.Location = New System.Drawing.Point(176, 59)
        Me.lbPiturePathList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbPiturePathList.Name = "lbPiturePathList"
        Me.lbPiturePathList.Size = New System.Drawing.Size(159, 394)
        Me.lbPiturePathList.TabIndex = 9
        Me.lbPiturePathList.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "(Delete 刪除選取)"
        '
        'btnChoseDestFolder
        '
        Me.btnChoseDestFolder.Image = Global.LazyImage.My.Resources.Resources.open_folder
        Me.btnChoseDestFolder.Location = New System.Drawing.Point(649, 9)
        Me.btnChoseDestFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnChoseDestFolder.Name = "btnChoseDestFolder"
        Me.btnChoseDestFolder.Size = New System.Drawing.Size(31, 29)
        Me.btnChoseDestFolder.TabIndex = 7
        Me.btnChoseDestFolder.UseVisualStyleBackColor = True
        '
        'tbDestPath
        '
        Me.tbDestPath.Location = New System.Drawing.Point(176, 9)
        Me.tbDestPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDestPath.Name = "tbDestPath"
        Me.tbDestPath.ReadOnly = True
        Me.tbDestPath.Size = New System.Drawing.Size(472, 25)
        Me.tbDestPath.TabIndex = 6
        Me.tbDestPath.Text = "D:\ppm"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(688, 9)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(67, 29)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "產生"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'tpCode
        '
        Me.tpCode.Controls.Add(Me.tbFileNamePrefix)
        Me.tpCode.Controls.Add(Me.Label4)
        Me.tpCode.Controls.Add(Me.btnGenerateCode)
        Me.tpCode.Controls.Add(Me.btnCopyCode)
        Me.tpCode.Controls.Add(Me.tbCode)
        Me.tpCode.Location = New System.Drawing.Point(4, 25)
        Me.tpCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpCode.Name = "tpCode"
        Me.tpCode.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpCode.Size = New System.Drawing.Size(771, 642)
        Me.tpCode.TabIndex = 1
        Me.tpCode.Text = "程式碼"
        Me.tpCode.UseVisualStyleBackColor = True
        '
        'tbFileNamePrefix
        '
        Me.tbFileNamePrefix.Location = New System.Drawing.Point(195, 9)
        Me.tbFileNamePrefix.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFileNamePrefix.Name = "tbFileNamePrefix"
        Me.tbFileNamePrefix.Size = New System.Drawing.Size(132, 25)
        Me.tbFileNamePrefix.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "檔名前綴"
        '
        'btnGenerateCode
        '
        Me.btnGenerateCode.Location = New System.Drawing.Point(8, 8)
        Me.btnGenerateCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerateCode.Name = "btnGenerateCode"
        Me.btnGenerateCode.Size = New System.Drawing.Size(100, 29)
        Me.btnGenerateCode.TabIndex = 2
        Me.btnGenerateCode.Text = "產生"
        Me.btnGenerateCode.UseVisualStyleBackColor = True
        '
        'btnCopyCode
        '
        Me.btnCopyCode.Location = New System.Drawing.Point(660, 8)
        Me.btnCopyCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCopyCode.Name = "btnCopyCode"
        Me.btnCopyCode.Size = New System.Drawing.Size(100, 29)
        Me.btnCopyCode.TabIndex = 1
        Me.btnCopyCode.Text = "複製"
        Me.btnCopyCode.UseVisualStyleBackColor = True
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(8, 44)
        Me.tbCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCode.Multiline = True
        Me.tbCode.Name = "tbCode"
        Me.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbCode.Size = New System.Drawing.Size(751, 586)
        Me.tbCode.TabIndex = 0
        '
        'ssMain
        '
        Me.ssMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMessage, Me.ToolStripStatusLabel1, Me.tsslGithub})
        Me.ssMain.Location = New System.Drawing.Point(0, 677)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ssMain.Size = New System.Drawing.Size(779, 25)
        Me.ssMain.TabIndex = 6
        '
        'tsslMessage
        '
        Me.tsslMessage.Image = Global.LazyImage.My.Resources.Resources.status_dot
        Me.tsslMessage.Name = "tsslMessage"
        Me.tsslMessage.Size = New System.Drawing.Size(72, 20)
        Me.tsslMessage.Text = "Status"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(560, 20)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'tsslGithub
        '
        Me.tsslGithub.Image = Global.LazyImage.My.Resources.Resources.github
        Me.tsslGithub.IsLink = True
        Me.tsslGithub.Name = "tsslGithub"
        Me.tsslGithub.Size = New System.Drawing.Size(127, 20)
        Me.tsslGithub.Text = "Skyle@github"
        '
        'ofd
        '
        Me.ofd.Filter = "Picture|*.bmp;*.jpg;*.jpeg;*.png"
        Me.ofd.Multiselect = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 702)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.tcMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lazy Image"
        CType(Me.pbThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tcMain.ResumeLayout(False)
        Me.tpGenerate.ResumeLayout(False)
        Me.tpGenerate.PerformLayout()
        CType(Me.pbOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCode.ResumeLayout(False)
        Me.tpCode.PerformLayout()
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPictureNameList As ListBox
    Friend WithEvents btnLoadPictures As Button
    Friend WithEvents pbThumbnail As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpCode As TabPage
    Friend WithEvents tpGenerate As TabPage
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents rbPercentage As RadioButton
    Friend WithEvents rbPixel As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents tbHorizontal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbVertical As TextBox
    Friend WithEvents btnTransform As Button
    Friend WithEvents btnRecovery As Button
    Friend WithEvents tbDestPath As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnChoseDestFolder As Button
    Friend WithEvents tbCode As TextBox
    Friend WithEvents btnCopyCode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbPiturePathList As ListBox
    Friend WithEvents pbOriginal As PictureBox
    Friend WithEvents tsslMessage As ToolStripStatusLabel
    Friend WithEvents fbd As FolderBrowserDialog
    Private WithEvents ofd As OpenFileDialog
    Friend WithEvents cbFixedRatio As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGenerateCode As Button
    Friend WithEvents tbFileNamePrefix As TextBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsslGithub As ToolStripStatusLabel
End Class
