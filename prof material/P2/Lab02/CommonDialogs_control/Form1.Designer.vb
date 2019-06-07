<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabCommonDialogs = New System.Windows.Forms.TabPage
        Me.btnBrowseFolder = New System.Windows.Forms.Button
        Me.btnSelectColor = New System.Windows.Forms.Button
        Me.btnSelectFont = New System.Windows.Forms.Button
        Me.btnSaveFile = New System.Windows.Forms.Button
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.txtDirectoryName = New System.Windows.Forms.TextBox
        Me.txtFileViewer = New System.Windows.Forms.TextBox
        Me.tabTimer = New System.Windows.Forms.TabPage
        Me.myOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.mySaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.myFontDialog = New System.Windows.Forms.FontDialog
        Me.myColorDialog = New System.Windows.Forms.ColorDialog
        Me.myFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabControl1.SuspendLayout()
        Me.tabCommonDialogs.SuspendLayout()
        Me.tabTimer.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCommonDialogs)
        Me.TabControl1.Controls.Add(Me.tabTimer)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(564, 358)
        Me.TabControl1.TabIndex = 0
        '
        'tabCommonDialogs
        '
        Me.tabCommonDialogs.Controls.Add(Me.btnBrowseFolder)
        Me.tabCommonDialogs.Controls.Add(Me.btnSelectColor)
        Me.tabCommonDialogs.Controls.Add(Me.btnSelectFont)
        Me.tabCommonDialogs.Controls.Add(Me.btnSaveFile)
        Me.tabCommonDialogs.Controls.Add(Me.btnOpenFile)
        Me.tabCommonDialogs.Controls.Add(Me.txtDirectoryName)
        Me.tabCommonDialogs.Controls.Add(Me.txtFileViewer)
        Me.tabCommonDialogs.Location = New System.Drawing.Point(4, 22)
        Me.tabCommonDialogs.Name = "tabCommonDialogs"
        Me.tabCommonDialogs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCommonDialogs.Size = New System.Drawing.Size(556, 332)
        Me.tabCommonDialogs.TabIndex = 0
        Me.tabCommonDialogs.Text = "Common dialogs"
        Me.tabCommonDialogs.UseVisualStyleBackColor = True
        '
        'btnBrowseFolder
        '
        Me.btnBrowseFolder.Location = New System.Drawing.Point(433, 287)
        Me.btnBrowseFolder.Name = "btnBrowseFolder"
        Me.btnBrowseFolder.Size = New System.Drawing.Size(107, 31)
        Me.btnBrowseFolder.TabIndex = 6
        Me.btnBrowseFolder.Text = "Browse folder"
        Me.btnBrowseFolder.UseVisualStyleBackColor = True
        '
        'btnSelectColor
        '
        Me.btnSelectColor.Location = New System.Drawing.Point(433, 203)
        Me.btnSelectColor.Name = "btnSelectColor"
        Me.btnSelectColor.Size = New System.Drawing.Size(107, 31)
        Me.btnSelectColor.TabIndex = 5
        Me.btnSelectColor.Text = "Select a color"
        Me.btnSelectColor.UseVisualStyleBackColor = True
        '
        'btnSelectFont
        '
        Me.btnSelectFont.Location = New System.Drawing.Point(433, 142)
        Me.btnSelectFont.Name = "btnSelectFont"
        Me.btnSelectFont.Size = New System.Drawing.Size(107, 31)
        Me.btnSelectFont.TabIndex = 4
        Me.btnSelectFont.Text = "Select a font"
        Me.btnSelectFont.UseVisualStyleBackColor = True
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(433, 81)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(107, 31)
        Me.btnSaveFile.TabIndex = 3
        Me.btnSaveFile.Text = "Save a file"
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(433, 20)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(107, 31)
        Me.btnOpenFile.TabIndex = 2
        Me.btnOpenFile.Text = "Open a file"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtDirectoryName
        '
        Me.txtDirectoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtDirectoryName.Location = New System.Drawing.Point(13, 287)
        Me.txtDirectoryName.Multiline = True
        Me.txtDirectoryName.Name = "txtDirectoryName"
        Me.txtDirectoryName.Size = New System.Drawing.Size(402, 31)
        Me.txtDirectoryName.TabIndex = 1
        '
        'txtFileViewer
        '
        Me.txtFileViewer.Location = New System.Drawing.Point(13, 13)
        Me.txtFileViewer.Multiline = True
        Me.txtFileViewer.Name = "txtFileViewer"
        Me.txtFileViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileViewer.Size = New System.Drawing.Size(400, 257)
        Me.txtFileViewer.TabIndex = 0
        '
        'tabTimer
        '
        Me.tabTimer.Controls.Add(Me.RichTextBox1)
        Me.tabTimer.Location = New System.Drawing.Point(4, 22)
        Me.tabTimer.Name = "tabTimer"
        Me.tabTimer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTimer.Size = New System.Drawing.Size(556, 332)
        Me.tabTimer.TabIndex = 1
        Me.tabTimer.Text = "Timer control"
        Me.tabTimer.UseVisualStyleBackColor = True
        '
        'myOpenFileDialog
        '
        Me.myOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'myFontDialog
        '
        '
        'myFolderBrowserDialog
        '
        Me.myFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(147, 64)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(255, 210)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 382)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.Text = "Common dialogs exercises"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCommonDialogs.ResumeLayout(False)
        Me.tabCommonDialogs.PerformLayout()
        Me.tabTimer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCommonDialogs As System.Windows.Forms.TabPage
    Friend WithEvents tabTimer As System.Windows.Forms.TabPage
    Friend WithEvents txtFileViewer As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseFolder As System.Windows.Forms.Button
    Friend WithEvents btnSelectColor As System.Windows.Forms.Button
    Friend WithEvents btnSelectFont As System.Windows.Forms.Button
    Friend WithEvents btnSaveFile As System.Windows.Forms.Button
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents txtDirectoryName As System.Windows.Forms.TextBox
    Friend WithEvents myOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mySaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents myFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents myColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents myFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
