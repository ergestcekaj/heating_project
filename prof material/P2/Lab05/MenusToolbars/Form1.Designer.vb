<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.myMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.myStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.myLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.myDateLable = New System.Windows.Forms.ToolStripStatusLabel()
        Me.myCapsLockStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.myProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.myContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeFontText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.myToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFileOpen = New System.Windows.Forms.Label()
        Me.txtFileOpen = New System.Windows.Forms.TextBox()
        Me.myFontDialog = New System.Windows.Forms.FontDialog()
        Me.myColorDialog = New System.Windows.Forms.ColorDialog()
        Me.myMenuStrip.SuspendLayout()
        Me.myStatusStrip.SuspendLayout()
        Me.myContextMenuStrip.SuspendLayout()
        Me.myToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'myMenuStrip
        '
        Me.myMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuEdit, Me.mnuHelp})
        Me.myMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.myMenuStrip.Name = "myMenuStrip"
        Me.myMenuStrip.Size = New System.Drawing.Size(324, 24)
        Me.myMenuStrip.TabIndex = 0
        Me.myMenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFile_Separator1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        Me.mnuFile.ToolTipText = "File Menu"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFile_Separator1
        '
        Me.mnuFile_Separator1.Name = "mnuFile_Separator1"
        Me.mnuFile_Separator1.Size = New System.Drawing.Size(143, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuView
        '
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuHelp
        '
        Me.mnuHelp.AutoToolTip = True
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Press to open help"
        '
        'myStatusStrip
        '
        Me.myStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.myLabel1, Me.myDateLable, Me.myCapsLockStatus, Me.myProgressBar})
        Me.myStatusStrip.Location = New System.Drawing.Point(0, 201)
        Me.myStatusStrip.Name = "myStatusStrip"
        Me.myStatusStrip.Size = New System.Drawing.Size(324, 24)
        Me.myStatusStrip.TabIndex = 1
        '
        'myLabel1
        '
        Me.myLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.myLabel1.Name = "myLabel1"
        Me.myLabel1.Size = New System.Drawing.Size(28, 19)
        Me.myLabel1.Text = "Info"
        '
        'myDateLable
        '
        Me.myDateLable.AutoToolTip = True
        Me.myDateLable.BackColor = System.Drawing.SystemColors.Control
        Me.myDateLable.Name = "myDateLable"
        Me.myDateLable.Size = New System.Drawing.Size(37, 19)
        Me.myDateLable.Text = " Date "
        '
        'myCapsLockStatus
        '
        Me.myCapsLockStatus.AutoToolTip = True
        Me.myCapsLockStatus.BackColor = System.Drawing.SystemColors.Control
        Me.myCapsLockStatus.Name = "myCapsLockStatus"
        Me.myCapsLockStatus.Size = New System.Drawing.Size(95, 19)
        Me.myCapsLockStatus.Text = "CapsLock status "
        Me.myCapsLockStatus.ToolTipText = "Status of the CapsLock button"
        '
        'myProgressBar
        '
        Me.myProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.myProgressBar.AutoToolTip = True
        Me.myProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.myProgressBar.Maximum = 100000
        Me.myProgressBar.Name = "myProgressBar"
        Me.myProgressBar.Size = New System.Drawing.Size(110, 18)
        Me.myProgressBar.Step = 5
        '
        'myContextMenuStrip
        '
        Me.myContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontText, Me.ChangeBackgroundColor})
        Me.myContextMenuStrip.Name = "myContextMenuStrip"
        Me.myContextMenuStrip.Size = New System.Drawing.Size(213, 48)
        '
        'ChangeFontText
        '
        Me.ChangeFontText.Name = "ChangeFontText"
        Me.ChangeFontText.Size = New System.Drawing.Size(212, 22)
        Me.ChangeFontText.Text = "Change text font"
        '
        'ChangeBackgroundColor
        '
        Me.ChangeBackgroundColor.Name = "ChangeBackgroundColor"
        Me.ChangeBackgroundColor.Size = New System.Drawing.Size(212, 22)
        Me.ChangeBackgroundColor.Text = "Change background color"
        '
        'myToolStrip
        '
        Me.myToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripComboBox1})
        Me.myToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.myToolStrip.Name = "myToolStrip"
        Me.myToolStrip.Size = New System.Drawing.Size(324, 25)
        Me.myToolStrip.TabIndex = 2
        Me.myToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoToolTip = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripLabel1.Text = "some Tool Bar"
        Me.ToolStripLabel1.ToolTipText = "Toolbar name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.ToolTipText = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(111, 25)
        '
        'Button1
        '
        Me.Button1.ContextMenuStrip = Me.myContextMenuStrip
        Me.Button1.Location = New System.Drawing.Point(229, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start progress bar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblFileOpen
        '
        Me.lblFileOpen.AutoSize = True
        Me.lblFileOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFileOpen.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFileOpen.Location = New System.Drawing.Point(25, 58)
        Me.lblFileOpen.Name = "lblFileOpen"
        Me.lblFileOpen.Size = New System.Drawing.Size(172, 15)
        Me.lblFileOpen.TabIndex = 4
        Me.lblFileOpen.Text = "The first low of geography"
        '
        'txtFileOpen
        '
        Me.txtFileOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFileOpen.ContextMenuStrip = Me.myContextMenuStrip
        Me.txtFileOpen.Location = New System.Drawing.Point(15, 80)
        Me.txtFileOpen.Multiline = True
        Me.txtFileOpen.Name = "txtFileOpen"
        Me.txtFileOpen.Size = New System.Drawing.Size(198, 81)
        Me.txtFileOpen.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(324, 225)
        Me.Controls.Add(Me.txtFileOpen)
        Me.Controls.Add(Me.lblFileOpen)
        Me.Controls.Add(Me.myToolStrip)
        Me.Controls.Add(Me.myStatusStrip)
        Me.Controls.Add(Me.myMenuStrip)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.myMenuStrip
        Me.Name = "Form1"
        Me.Text = "Manus and Toolbars exercise"
        Me.myMenuStrip.ResumeLayout(False)
        Me.myMenuStrip.PerformLayout()
        Me.myStatusStrip.ResumeLayout(False)
        Me.myStatusStrip.PerformLayout()
        Me.myContextMenuStrip.ResumeLayout(False)
        Me.myToolStrip.ResumeLayout(False)
        Me.myToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents myStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents myContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents myProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents myToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents myCapsLockStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents myDateLable As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblFileOpen As System.Windows.Forms.Label
    Friend WithEvents txtFileOpen As System.Windows.Forms.TextBox
    Friend WithEvents ChangeFontText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeBackgroundColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents myColorDialog As System.Windows.Forms.ColorDialog

End Class
