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
        Me.btnCreateDir = New System.Windows.Forms.Button
        Me.btnMoveDir = New System.Windows.Forms.Button
        Me.lblInfo = New System.Windows.Forms.Label
        Me.btnDriveInfo = New System.Windows.Forms.Button
        Me.lblDriveName = New System.Windows.Forms.Label
        Me.lblTotalSize = New System.Windows.Forms.Label
        Me.lblFileSystem = New System.Windows.Forms.Label
        Me.lblTotalFreeSpace = New System.Windows.Forms.Label
        Me.btnCreateFile = New System.Windows.Forms.Button
        Me.btnReadFile = New System.Windows.Forms.Button
        Me.btnWriteFile = New System.Windows.Forms.Button
        Me.txtFileViewer = New System.Windows.Forms.TextBox
        Me.btnWriteFile2 = New System.Windows.Forms.Button
        Me.btnReadFile2 = New System.Windows.Forms.Button
        Me.btnCopyFile = New System.Windows.Forms.Button
        Me.btnDeleteFile = New System.Windows.Forms.Button
        Me.btnRenameFile = New System.Windows.Forms.Button
        Me.btnMoveFile = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCreateDir
        '
        Me.btnCreateDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCreateDir.Location = New System.Drawing.Point(25, 68)
        Me.btnCreateDir.Name = "btnCreateDir"
        Me.btnCreateDir.Size = New System.Drawing.Size(130, 32)
        Me.btnCreateDir.TabIndex = 0
        Me.btnCreateDir.Text = "Create a directory"
        Me.btnCreateDir.UseVisualStyleBackColor = True
        '
        'btnMoveDir
        '
        Me.btnMoveDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMoveDir.Location = New System.Drawing.Point(178, 68)
        Me.btnMoveDir.Name = "btnMoveDir"
        Me.btnMoveDir.Size = New System.Drawing.Size(124, 32)
        Me.btnMoveDir.TabIndex = 1
        Me.btnMoveDir.Text = "Move a directory"
        Me.btnMoveDir.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(22, 27)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(210, 17)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "[ Here will appear an information ]"
        '
        'btnDriveInfo
        '
        Me.btnDriveInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDriveInfo.Location = New System.Drawing.Point(465, 83)
        Me.btnDriveInfo.Name = "btnDriveInfo"
        Me.btnDriveInfo.Size = New System.Drawing.Size(108, 27)
        Me.btnDriveInfo.TabIndex = 3
        Me.btnDriveInfo.Text = "Get drive info"
        Me.btnDriveInfo.UseVisualStyleBackColor = True
        '
        'lblDriveName
        '
        Me.lblDriveName.AutoSize = True
        Me.lblDriveName.Location = New System.Drawing.Point(421, 19)
        Me.lblDriveName.Name = "lblDriveName"
        Me.lblDriveName.Size = New System.Drawing.Size(63, 13)
        Me.lblDriveName.TabIndex = 4
        Me.lblDriveName.Text = "Drive Name"
        '
        'lblTotalSize
        '
        Me.lblTotalSize.AutoSize = True
        Me.lblTotalSize.Location = New System.Drawing.Point(512, 19)
        Me.lblTotalSize.Name = "lblTotalSize"
        Me.lblTotalSize.Size = New System.Drawing.Size(82, 13)
        Me.lblTotalSize.TabIndex = 5
        Me.lblTotalSize.Text = "Total Drive Size"
        '
        'lblFileSystem
        '
        Me.lblFileSystem.AutoSize = True
        Me.lblFileSystem.Location = New System.Drawing.Point(421, 48)
        Me.lblFileSystem.Name = "lblFileSystem"
        Me.lblFileSystem.Size = New System.Drawing.Size(60, 13)
        Me.lblFileSystem.TabIndex = 6
        Me.lblFileSystem.Text = "File System"
        '
        'lblTotalFreeSpace
        '
        Me.lblTotalFreeSpace.AutoSize = True
        Me.lblTotalFreeSpace.Location = New System.Drawing.Point(512, 48)
        Me.lblTotalFreeSpace.Name = "lblTotalFreeSpace"
        Me.lblTotalFreeSpace.Size = New System.Drawing.Size(89, 13)
        Me.lblTotalFreeSpace.TabIndex = 7
        Me.lblTotalFreeSpace.Text = "Total Free Space"
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCreateFile.Location = New System.Drawing.Point(379, 180)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(111, 32)
        Me.btnCreateFile.TabIndex = 8
        Me.btnCreateFile.Text = "Create a file"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'btnReadFile
        '
        Me.btnReadFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnReadFile.Location = New System.Drawing.Point(379, 285)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(111, 32)
        Me.btnReadFile.TabIndex = 9
        Me.btnReadFile.Text = "Read from file"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnWriteFile.Location = New System.Drawing.Point(379, 235)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(111, 32)
        Me.btnWriteFile.TabIndex = 10
        Me.btnWriteFile.Text = "Write to file"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'txtFileViewer
        '
        Me.txtFileViewer.Location = New System.Drawing.Point(12, 148)
        Me.txtFileViewer.Multiline = True
        Me.txtFileViewer.Name = "txtFileViewer"
        Me.txtFileViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileViewer.Size = New System.Drawing.Size(336, 275)
        Me.txtFileViewer.TabIndex = 11
        '
        'btnWriteFile2
        '
        Me.btnWriteFile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnWriteFile2.Location = New System.Drawing.Point(515, 235)
        Me.btnWriteFile2.Name = "btnWriteFile2"
        Me.btnWriteFile2.Size = New System.Drawing.Size(112, 32)
        Me.btnWriteFile2.TabIndex = 12
        Me.btnWriteFile2.Text = "Write to file 2"
        Me.btnWriteFile2.UseVisualStyleBackColor = True
        '
        'btnReadFile2
        '
        Me.btnReadFile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnReadFile2.Location = New System.Drawing.Point(515, 285)
        Me.btnReadFile2.Name = "btnReadFile2"
        Me.btnReadFile2.Size = New System.Drawing.Size(112, 32)
        Me.btnReadFile2.TabIndex = 13
        Me.btnReadFile2.Text = "Read from file 2"
        Me.btnReadFile2.UseVisualStyleBackColor = True
        '
        'btnCopyFile
        '
        Me.btnCopyFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCopyFile.Location = New System.Drawing.Point(379, 336)
        Me.btnCopyFile.Name = "btnCopyFile"
        Me.btnCopyFile.Size = New System.Drawing.Size(111, 32)
        Me.btnCopyFile.TabIndex = 14
        Me.btnCopyFile.Text = "Copy a file"
        Me.btnCopyFile.UseVisualStyleBackColor = True
        '
        'btnDeleteFile
        '
        Me.btnDeleteFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDeleteFile.Location = New System.Drawing.Point(515, 336)
        Me.btnDeleteFile.Name = "btnDeleteFile"
        Me.btnDeleteFile.Size = New System.Drawing.Size(112, 32)
        Me.btnDeleteFile.TabIndex = 15
        Me.btnDeleteFile.Text = "Delete a file"
        Me.btnDeleteFile.UseVisualStyleBackColor = True
        '
        'btnRenameFile
        '
        Me.btnRenameFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRenameFile.Location = New System.Drawing.Point(516, 386)
        Me.btnRenameFile.Name = "btnRenameFile"
        Me.btnRenameFile.Size = New System.Drawing.Size(111, 32)
        Me.btnRenameFile.TabIndex = 16
        Me.btnRenameFile.Text = "Rename a file"
        Me.btnRenameFile.UseVisualStyleBackColor = True
        '
        'btnMoveFile
        '
        Me.btnMoveFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMoveFile.Location = New System.Drawing.Point(379, 386)
        Me.btnMoveFile.Name = "btnMoveFile"
        Me.btnMoveFile.Size = New System.Drawing.Size(112, 32)
        Me.btnMoveFile.TabIndex = 17
        Me.btnMoveFile.Text = "Move a file"
        Me.btnMoveFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 435)
        Me.Controls.Add(Me.btnMoveFile)
        Me.Controls.Add(Me.btnRenameFile)
        Me.Controls.Add(Me.btnDeleteFile)
        Me.Controls.Add(Me.btnCopyFile)
        Me.Controls.Add(Me.btnReadFile2)
        Me.Controls.Add(Me.btnWriteFile2)
        Me.Controls.Add(Me.txtFileViewer)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Controls.Add(Me.lblTotalFreeSpace)
        Me.Controls.Add(Me.lblFileSystem)
        Me.Controls.Add(Me.lblTotalSize)
        Me.Controls.Add(Me.lblDriveName)
        Me.Controls.Add(Me.btnDriveInfo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnMoveDir)
        Me.Controls.Add(Me.btnCreateDir)
        Me.Name = "Form1"
        Me.Text = "Manipulating files and directories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateDir As System.Windows.Forms.Button
    Friend WithEvents btnMoveDir As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnDriveInfo As System.Windows.Forms.Button
    Friend WithEvents lblDriveName As System.Windows.Forms.Label
    Friend WithEvents lblTotalSize As System.Windows.Forms.Label
    Friend WithEvents lblFileSystem As System.Windows.Forms.Label
    Friend WithEvents lblTotalFreeSpace As System.Windows.Forms.Label
    Friend WithEvents btnCreateFile As System.Windows.Forms.Button
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents btnWriteFile As System.Windows.Forms.Button
    Friend WithEvents txtFileViewer As System.Windows.Forms.TextBox
    Friend WithEvents btnWriteFile2 As System.Windows.Forms.Button
    Friend WithEvents btnReadFile2 As System.Windows.Forms.Button
    Friend WithEvents btnCopyFile As System.Windows.Forms.Button
    Friend WithEvents btnDeleteFile As System.Windows.Forms.Button
    Friend WithEvents btnRenameFile As System.Windows.Forms.Button
    Friend WithEvents btnMoveFile As System.Windows.Forms.Button

End Class
