Public Class Questionnaire
    Dim myName As String
    Dim myAge As String
    Dim myCountry As String
    Dim GrbHobby As String
    Dim GrbGender As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboCountry.Sorted = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblTitle.Click

    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Me.Close()
    End Sub

    Private Sub CboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCountry.SelectedIndexChanged


    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim name As String
        name = InputBox("Type name of the country of your birth if it isn't found on the list", "Add country name")
        CboCountry.Items.Add(name)

    End Sub

    Private Sub GrbGender_Enter(sender As Object, e As EventArgs) Handles GrbGender.Enter

    End Sub

    Private Sub GrbHobby_Enter(sender As Object, e As EventArgs) Handles GrbHobby.Enter

    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles BtnSummary.Click
        myName = txtName.Text
        myAge = lstAge.SelectedItem


        If ChkMale.Checked Then
            GrbGender = ChkMale.Text
        ElseIf rdbFemale.Checked Then
            GrbGender = ChkFemale.Text
        End If


        If chkReading.Checked = True Then
            GrbHobby = "Reading"
        ElseIf ChkSleeping.Checked = True Then
            GrbHobby = "Sleeping"
        ElseIf ChkEating.Checked = True Then
            GrbHobby = "Eating"
        ElseIf ChkDrinking.Checked = True Then
            GrbHobby = "Drinking"
        End If
        myCountry = CboCountry.SelectedItem

        MsgBox(myName & ", " & myAge & ", " & GbrGender & ", " & GbrHobby & ", " & myCountry, MsgBoxStyle.OkOnly, "Summary")
        'use vbCrLf 


    End Sub
End Class
