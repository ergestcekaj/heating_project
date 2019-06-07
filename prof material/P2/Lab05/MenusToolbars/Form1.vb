Imports System.IO
Public Class Form1

    Private Sub ToolStripMenuItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile.MouseEnter, mnuView.MouseEnter, mnuEdit.MouseEnter, mnuHelp.MouseEnter
        'Dim selected As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        myLabel1.Text = sender.Text 'selected.Text
    End Sub
    ' No text is presented on the Label when mouse pointer leaves one of the MenuStrip item
    Private Sub ToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile.MouseLeave, mnuView.MouseLeave, mnuEdit.MouseLeave, mnuHelp.MouseLeave
        myLabel1.Text = ""
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If My.Computer.Keyboard.CapsLock Then
            myCapsLockStatus.Text = "CAP"
            'myCapsLockStatus.BorderStyle = Border3DStyle.Raised
        Else
            myCapsLockStatus.Text = "   "
            'myCapsLockStatus.BorderStyle = Border3DStyle.Sunken
        End If
    End Sub

    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Present date on the date Lable on status bar
        myDateLable.Text = Today '.ToShortDateString
        ' If the capslock key changes then change the value of the capslock status label.
        If My.Computer.Keyboard.CapsLock Then
            myCapsLockStatus.Text = "CAP"
        Else
            myCapsLockStatus.Text = "   "
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myProgressBar.Value = 0
        myProgressBar.Maximum = 1000000
        myProgressBar.Step = 1
        Do Until myProgressBar.Value = myProgressBar.Maximum
            myProgressBar.Increment(myProgressBar.Step)
        Loop
        'MessageBox.Show("The end of the progress bar incrementation")
        'myProgressBar.Value = myProgressBar.Minimum
    End Sub
    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        Const FILE_NAME As String = "D:\Users\P2\Lab05\flog.txt"
        If File.Exists(FILE_NAME) Then
            txtFileOpen.Text = File.ReadAllText(FILE_NAME)
        Else
            MsgBox("File does not exist", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub ChangeFontText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFontText.Click
        If myFontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFileOpen.Font = myFontDialog.Font
        End If
    End Sub
    Private Sub ChangeBackgroundColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeBackgroundColor.Click
        If myColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFileOpen.BackColor = myColorDialog.Color
        End If
    End Sub
    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

   
End Class
