Imports System.Math
Imports System.Console


Public Class Calculate
    'declaring the variables
    Dim strcountry, strmaterial As String
    Dim intcountry, intmaterial As Integer
    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        Me.Close()
    End Sub

    'Reset button in order to clear the fields for more calculation
    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click


        TextBox_volume.Text = ""
        TextBox_temperature.Text = ""
        TextBox_energy.Text = ""
        TextBox_cost.Text = ""

    End Sub

    Private Sub Button_calculate_Click(sender As Object, e As EventArgs) Handles Button_calculate.Click

        Dim Dbvolume, Dbtemperature, dbenergy, dbcost As Double

        Dim strmessage As String
        'Here I told the program that the variable int.. has to take the values from the combobox...
        intmaterial = ComboBoxMaterials.SelectedIndex
        intcountry = ComboBoxCountries.SelectedIndex

        If IsNumeric(TextBox_volume.Text) And IsNumeric(TextBox_temperature.Text) Then
            If (ComboBoxMaterials.SelectedIndex >= 0) Then
                If (ComboBoxCountries.SelectedIndex >= 0) Then
                    Dbvolume = CDbl(TextBox_volume.Text)
                    Dbtemperature = CDbl(TextBox_temperature.Text)


                    Dim Class1object As New Class1(Dbvolume, Dbtemperature, intcountry, intmaterial)

                    dbenergy = Class1object.GETEnergy
                    dbcost = Class1object.Getcost

                    TextBox_energy.BackColor = Color.White
                    TextBox_energy.Text = dbenergy.ToString("##0.00000")

                    TextBox_energy.BackColor = Color.White
                    TextBox_cost.Text = dbcost.ToString("##0.000000")
                Else
                    strmessage = ""
                    If (ComboBoxCountries.SelectedIndex = -1) Then strmessage = strmessage & "Please select one country " & vbCr
                    MsgBox(strmessage, MsgBoxStyle.Information, "Information")

                End If

            Else
                strmessage = ""
                If (ComboBoxMaterials.SelectedIndex = -1) Then strmessage = strmessage & "Please select one material" & vbCr
                MsgBox(strmessage, MsgBoxStyle.Information, "Information")

            End If

                Else

                ' in case a proper integer value is not emited from the user a message will show up and the field will be cleared
                strmessage = ""
            If Not IsNumeric(TextBox_volume.Text) Then strmessage = strmessage & "Volume is incorrect" & vbCr
            If Not IsNumeric(TextBox_temperature.Text) Then strmessage = strmessage & "Temperature is incorrect" _
                & vbCr & "Please update input(s)!"
            MsgBox(strmessage, MsgBoxStyle.Information, "Information")
            TextBox_temperature.Text = ""
            TextBox_volume.Text = ""
            TextBox_energy.Text = ""
            TextBox_cost.Text = ""

        End If

        Me.BackColor = SystemColors.ControlLightLight

    End Sub

    Private Sub Button_info_Click(sender As Object, e As EventArgs) Handles Button_info.Click
        Information.Show()
    End Sub

    Private Sub Button_rank_them_Click(sender As Object, e As EventArgs) Handles Button_rank_them.Click
        rankForm.Show()
    End Sub

    Private Sub TextBox_temperature_TextChanged(sender As Object, e As EventArgs) Handles TextBox_temperature.TextChanged

    End Sub

    Private Sub TextBox_volume_TextChanged(sender As Object, e As EventArgs) Handles TextBox_volume.TextChanged

    End Sub
End Class
