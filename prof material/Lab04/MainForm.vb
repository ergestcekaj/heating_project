' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.IO

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' The code below uses the new StringWriter to build a string in memory.
        ' The WriteLine commands append code to the string buffer with carriage return and line feed.
        Dim writer As StringWriter = New StringWriter()

        With writer
            .WriteLine("Enter a file name & path to test error handling. ")
            .WriteLine("Try different combinations for example:")
            .WriteLine("")
            .WriteLine("  D:\Users\P2\Lab04\Filename.txt")
            .WriteLine("  D:\Users\P2\Lab04\FolderName\Filename.txt")
            .WriteLine("  \\ServerName\FolderName\Filename.txt")
        End With

        ' Ask the StringWriter to covert its buffer to a string
        Me.txtMessage.Text = writer.ToString()
    End Sub

    Private Sub cmdNoTryCatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoTryCatch.Click
        ' Ask to make sure the user is willing to possibly blow up the program.
        Dim message As String = "The following code has no error handling and will cause an unhandled exception if a file is not found. Do you want to continue?"
        If MessageBox.Show(message, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            ' Use the FileStream class from the System.IO Namespace (see Imports at top of file).
            Dim fs As FileStream

            ' This command will fail if the file does not exist.
            fs = File.Open(Me.txtFileName.Text, FileMode.Open)
            MessageBox.Show("The size of the file is: " & fs.Length, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            fs.Close()
        End If
    End Sub

    Private Sub txtFileName_TextChanged(sender As Object, e As EventArgs) Handles txtFileName.TextChanged

    End Sub

    Private Sub cmdBasicTryCatch_Click(sender As Object, e As EventArgs) Handles cmdBasicTryCatch.Click
        Try
            My.Computer.FileSystem.CopyFile("My file", "My new file ")
        Catch e As Exception
            MsgBox("An error occured")
        Finally
        End Try
    End Sub
End Class