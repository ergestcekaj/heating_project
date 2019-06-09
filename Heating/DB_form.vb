﻿Public Class DB_form
    Dim Com As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = C:\Users\Eddi\source\repos\heating_project\Heating\bin\Debug\Heating_DB.mdb"
    Dim sql As String ' sql statement

    Dim operationsUtils As OperationsUtils = OperationsUtils.GetInstance

    Public Sub saveuser(User_name As String, pass_txt As String, Question As String, answer_txt As String, bytImage() As Byte)
        con.ConnectionString = dbProvider & dbSource
        con.Open()

        Dim Sql = "INSERT INTO Heating_DB.HEATING ([name],[Duration],[Date],[Cost]) 
            VALUES(ComboBox_name,TextBox_duration,ComboBox_dat)"
        Dim Com = New OleDb.OleDbCommand(Sql, con)
        Com.Parameters.AddWithValue("@User_name", User_name)
        Com.Parameters.AddWithValue("@password", pass_txt)
        Com.Parameters.AddWithValue("@Question", Question)
        Com.Parameters.AddWithValue("@Answer", answer_txt)
        Com.Parameters.AddWithValue("@Image", bytImage)

        Com.ExecuteNonQuery()


    End Sub
    Private Sub DB_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDataGrid()
        calculateTotalCost()
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Dim filter As Filter = New Filter()
        filter.Name_list = retrieveSelectedValuesFrom(ListBox_Name)
        filter.Month_list = retrieveSelectedValuesFrom(ListBox_Month)

        If checkValidity(filter) Then
            fillDataGrid(filter)
            calculateTotalCost()

        End If


    End Sub

    Private Sub fillDataGrid()
        DataGridView_Filtered_Data.DataSource = operationsUtils.fetchAllHeatingData().Tables(0)
    End Sub

    Private Sub fillDataGrid(filter As Filter)
        DataGridView_Filtered_Data.DataSource = operationsUtils.filterData(filter).Tables(0)
    End Sub

    Private Sub calculateTotalCost()
        Dim totalCost As Integer = 0
        For index As Integer = 0 To DataGridView_Filtered_Data.RowCount - 1
            totalCost += Convert.ToInt32(DataGridView_Filtered_Data.Rows(index).Cells(4).Value)
        Next
        Label_Total_Cost.Text = totalCost.ToString()
    End Sub

    Private Function retrieveSelectedValuesFrom(listBox As ListBox) As ArrayList
        Dim tmpArrayList As ArrayList = New ArrayList()
        For index As Integer = 0 To listBox.SelectedItems.Count - 1
            Dim selectName = listBox.SelectedItems.Item(index)
            tmpArrayList.Add(selectName)
        Next
        Return tmpArrayList
    End Function

    Private Function checkValidity(filter As Filter) As Boolean
        If filter.Name_list.Count = 0 And filter.Month_list.Count = 0 Then
            MessageBox.Show("Please select data from Names and Months")
            Return False
        End If
        Return True
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Month.SelectedIndexChanged

    End Sub
End Class