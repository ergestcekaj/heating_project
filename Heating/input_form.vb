Imports System.Data.OleDb
Imports System
Imports System.Data.SqlClient

Public Class input_form

    Dim operationsUtils As OperationsUtils = OperationsUtils.GetInstance

    Private Sub Button_Insert_Click(sender As Object, e As EventArgs) Handles Button_Insert.Click
        Dim cost = Calculate.TextBox_cost.Text
        If checkCost(cost) Then
            Dim heatingModel As Heating = New Heating()
            heatingModel.Name = ComboBox_name.SelectedItem.ToString
            heatingModel.Duration = Convert.ToInt32(TextBox_duration.Text)
            heatingModel.months = ComboBox_month.SelectedItem.ToString
            heatingModel.cost = heatingModel.Duration * 3.6 * Convert.ToDouble(cost)
            operationsUtils.insert(heatingModel)
            fillDataGrid()
        Else
            MessageBox.Show(" Please calculate the cost in the previous view")

        End If

    End Sub

    Private Sub Input_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDataGrid()
    End Sub

    Private Sub fillDataGrid()
        DataGridView1.DataSource = operationsUtils.fetchAllHeatingData().Tables(0)
    End Sub

    Private Sub Button_operations_Click(sender As Object, e As EventArgs) Handles Button_operations.Click
        DB_form.Show()
    End Sub

    Private Function checkCost(cost As String) As Boolean
        If cost Is Nothing Or cost = "" Then
            Return False
        End If
        Return True
    End Function
End Class
