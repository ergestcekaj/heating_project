Public Class DB_form
    'This is the operation form responsable for filtring the data and the creation of the file

    Dim operationsUtils As OperationsUtils = OperationsUtils.GetInstance

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
            totalCost += Convert.ToInt32(getDataGridValueAt(index, 4))
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
        If filter.Name_list.Count = 0 Or filter.Month_list.Count = 0 Then
            MessageBox.Show("Please select data from Names and Months")
            Return False
        End If
        Return True
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Month.SelectedIndexChanged

    End Sub

    Private Sub Button_Extract_Click(sender As Object, e As EventArgs) Handles Button_Extract.Click
        Dim tmpArrayList As ArrayList = New ArrayList()
        For index As Integer = 0 To DataGridView_Filtered_Data.RowCount - 1
            Dim heating As Heating = New Heating()
            heating.id = Convert.ToInt32(getDataGridValueAt(index, 0))
            heating.cost = Convert.ToDouble(getDataGridValueAt(index, 4))
            heating.Duration = Convert.ToDouble(getDataGridValueAt(index, 2))
            heating.months = Convert.ToString(getDataGridValueAt(index, 3))
            heating.Name = Convert.ToString(getDataGridValueAt(index, 1))

            tmpArrayList.Add(heating)
        Next

        If operationsUtils.exportToFile(tmpArrayList) Then
            MessageBox.Show("Done")
        End If


    End Sub

    Private Function getDataGridValueAt(row As Integer, column As Integer) As Object
        Return DataGridView_Filtered_Data.Rows(row).Cells(column).Value
    End Function
End Class