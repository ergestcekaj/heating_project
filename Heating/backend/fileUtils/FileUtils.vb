Public Class FileUtils
    'This class was created for every action on the input or output files

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetInstance As FileUtils
        Get
            Static Instance As FileUtils = New FileUtils
            Return Instance
        End Get
    End Property

    Public Function exportToFile(list As ArrayList) As Boolean
        'The file is being created
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Constants.FILE_NAME, False)

        For index As Integer = 0 To list.Count - 1

            file.WriteLine(heatingToString(list.Item(index)))
        Next
        file.Close()

        Return True
    End Function

    Private Function heatingToString(heating As Heating) As String
        'The values are converted to string before extracting them in a csv file
        Dim heatingInString = ""
        heatingInString += Convert.ToString(heating.id) + ";"
        heatingInString += Convert.ToString(heating.Name) + ";"
        heatingInString += Convert.ToString(heating.Duration) + ";"
        heatingInString += Convert.ToString(heating.months) + ";"
        heatingInString += Convert.ToString(heating.cost) + ";"
        Return heatingInString.Trim().Remove(heatingInString.Length - 1)
    End Function
End Class
