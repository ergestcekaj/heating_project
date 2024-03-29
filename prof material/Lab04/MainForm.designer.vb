﻿Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
        Me.grpCommands = New System.Windows.Forms.GroupBox()
        Me.cmdCustomMessage = New System.Windows.Forms.Button()
        Me.cmdTryCatchFinally = New System.Windows.Forms.Button()
        Me.cmdDetailedTryCatch = New System.Windows.Forms.Button()
        Me.cmdBasicTryCatch = New System.Windows.Forms.Button()
        Me.cmdNoTryCatch = New System.Windows.Forms.Button()
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.grpCommands.SuspendLayout()
        Me.grpInputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommands
        '
        Me.grpCommands.Controls.Add(Me.cmdCustomMessage)
        Me.grpCommands.Controls.Add(Me.cmdTryCatchFinally)
        Me.grpCommands.Controls.Add(Me.cmdDetailedTryCatch)
        Me.grpCommands.Controls.Add(Me.cmdBasicTryCatch)
        Me.grpCommands.Controls.Add(Me.cmdNoTryCatch)
        Me.grpCommands.Location = New System.Drawing.Point(354, 12)
        Me.grpCommands.Name = "grpCommands"
        Me.grpCommands.Size = New System.Drawing.Size(204, 184)
        Me.grpCommands.TabIndex = 2
        Me.grpCommands.TabStop = False
        Me.grpCommands.Text = "Approaches to error handling"
        '
        'cmdCustomMessage
        '
        Me.cmdCustomMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCustomMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCustomMessage.Location = New System.Drawing.Point(8, 120)
        Me.cmdCustomMessage.Name = "cmdCustomMessage"
        Me.cmdCustomMessage.Size = New System.Drawing.Size(186, 23)
        Me.cmdCustomMessage.TabIndex = 3
        Me.cmdCustomMessage.Text = "&Custom Message"
        '
        'cmdTryCatchFinally
        '
        Me.cmdTryCatchFinally.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTryCatchFinally.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTryCatchFinally.Location = New System.Drawing.Point(8, 152)
        Me.cmdTryCatchFinally.Name = "cmdTryCatchFinally"
        Me.cmdTryCatchFinally.Size = New System.Drawing.Size(186, 23)
        Me.cmdTryCatchFinally.TabIndex = 4
        Me.cmdTryCatchFinally.Text = "&Try, Catch, Finally"
        '
        'cmdDetailedTryCatch
        '
        Me.cmdDetailedTryCatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDetailedTryCatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDetailedTryCatch.Location = New System.Drawing.Point(8, 88)
        Me.cmdDetailedTryCatch.Name = "cmdDetailedTryCatch"
        Me.cmdDetailedTryCatch.Size = New System.Drawing.Size(186, 23)
        Me.cmdDetailedTryCatch.TabIndex = 2
        Me.cmdDetailedTryCatch.Text = "&Detailed Error Handling"
        '
        'cmdBasicTryCatch
        '
        Me.cmdBasicTryCatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBasicTryCatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBasicTryCatch.Location = New System.Drawing.Point(8, 56)
        Me.cmdBasicTryCatch.Name = "cmdBasicTryCatch"
        Me.cmdBasicTryCatch.Size = New System.Drawing.Size(186, 23)
        Me.cmdBasicTryCatch.TabIndex = 1
        Me.cmdBasicTryCatch.Text = "&Basic Error Handling"
        '
        'cmdNoTryCatch
        '
        Me.cmdNoTryCatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNoTryCatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNoTryCatch.Location = New System.Drawing.Point(8, 24)
        Me.cmdNoTryCatch.Name = "cmdNoTryCatch"
        Me.cmdNoTryCatch.Size = New System.Drawing.Size(186, 23)
        Me.cmdNoTryCatch.TabIndex = 0
        Me.cmdNoTryCatch.Text = "&No Error Handling"
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.txtMessage)
        Me.grpInputs.Controls.Add(Me.lblFileName)
        Me.grpInputs.Controls.Add(Me.txtFileName)
        Me.grpInputs.Location = New System.Drawing.Point(12, 12)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(328, 184)
        Me.grpInputs.TabIndex = 3
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Test data"
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.BackColor = System.Drawing.SystemColors.Control
        Me.txtMessage.Location = New System.Drawing.Point(16, 75)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(299, 100)
        Me.txtMessage.TabIndex = 2
        Me.txtMessage.Text = "Message will be loaded in Form_Load."
        '
        'lblFileName
        '
        Me.lblFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFileName.Location = New System.Drawing.Point(16, 24)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(299, 18)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "Text File To &Open"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(16, 43)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(299, 20)
        Me.txtFileName.TabIndex = 1
        Me.txtFileName.Text = "D:\MyDir\filename.txt"
        '
        'MainForm
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(570, 209)
        Me.Controls.Add(Me.grpCommands)
        Me.Controls.Add(Me.grpInputs)
        Me.Name = "MainForm"
        Me.Text = "Structured error handling"
        Me.grpCommands.ResumeLayout(False)
        Me.grpInputs.ResumeLayout(False)
        Me.grpInputs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend Shared ReadOnly Property GetInstance() As MainForm
        Get
            If m_DefaultInstance Is Nothing OrElse m_DefaultInstance.IsDisposed() Then
                SyncLock m_SyncObject
                    If m_DefaultInstance Is Nothing OrElse m_DefaultInstance.IsDisposed() Then
                        m_DefaultInstance = New MainForm
                    End If
                End SyncLock
            End If
            Return m_DefaultInstance
        End Get
    End Property

    Private Shared m_DefaultInstance As MainForm
    Private Shared m_SyncObject As New Object
    Friend WithEvents grpCommands As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCustomMessage As System.Windows.Forms.Button
    Friend WithEvents cmdTryCatchFinally As System.Windows.Forms.Button
    Friend WithEvents cmdDetailedTryCatch As System.Windows.Forms.Button
    Friend WithEvents cmdBasicTryCatch As System.Windows.Forms.Button
    Friend WithEvents cmdNoTryCatch As System.Windows.Forms.Button
    Friend WithEvents grpInputs As System.Windows.Forms.GroupBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem

End Class
