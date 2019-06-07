Imports System
' Imports namespaces or programming elements defined in referenced projects and assemblies. 
' Also imports namespaces or elements defined within the same project.
Imports System.IO

Public Class Form1

    Private Sub btnDriveInfo_Click(sender As Object, e As EventArgs) Handles btnDriveInfo.Click

        Dim myAllDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim myDrive As DriveInfo

        myDrive = myAllDrives(1)

        If myDrive.IsReady = True Then
            lblDriveName.Text = myDrive.Name
            lblFileSystem.Text = myDrive.DriveFormat
            lblTotalSize.Text = myDrive.TotalSize & " bytes"
            lblTotalFreeSpace.Text = myDrive.TotalFreeSpace & " bytes"
        End If

    End Sub

End Class
