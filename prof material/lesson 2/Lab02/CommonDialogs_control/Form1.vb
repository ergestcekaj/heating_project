Public Class frmMain


    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        myOpenFileDialog.Filter = "Text file (*.txt)|*.txt|All files|*.*"
        myOpenFileDialog.CheckFileExists = True
        myOpenFileDialog.Title = "Select a file to open"
        If myOpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(myOpenFileDialog.FileName)
            Dim myText As String
            myText = sr.ReadToEnd
            MessageBox.Show(myText)
            sr.Close()

        End If




    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click

        mySaveFileDialog.DefaultExt = True
        mySaveFileDialog.CheckFileExists = True
        mySaveFileDialog.Title = "Save a text file"
        mySaveFileDialog.Filter = "Text files (*.txt|*.txt|All files|*.* "
        mySaveFileDialog.ShowHelp = True
        If mySaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(mySaveFileDialog.FileName, txtFileViewer.Text, False)
        End If
        
    End Sub

    Private Sub btnSelectFont_Click(sender As Object, e As EventArgs) Handles btnSelectFont.Click
        If myFontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDirectoryName= myFontDialog.Font

        End If
    End Sub

    Private Sub btnSelectColor_Click(sender As Object, e As EventArgs) Handles btnSelectColor.Click
        If myColorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFileViewer.ForeColor = myColorDialog.Color

        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class

