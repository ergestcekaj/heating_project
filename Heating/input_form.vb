Imports System.Data.OleDb
Imports System
Imports System.Data.SqlClient

Public Class input_form
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = C:\Users\Eddi\source\repos\heating_project\Heating\bin\Debug\Heating_DB.mdb"
    Dim sql As String ' sql statement

    Dim operationsUtils As OperationsUtils = OperationsUtils.GetInstance

    Private Sub Button_Insert_Click(sender As Object, e As EventArgs) Handles Button_Insert.Click
        Dim cost = Calculate.TextBox_cost.Text
        Dim heatingModel As Heating = New Heating()

        heatingModel.Name = ComboBox_name.SelectedItem.ToString
        heatingModel.Duration = Convert.ToInt32(TextBox_duration.Text)
        heatingModel.months = ComboBox_month.SelectedItem.ToString
        heatingModel.cost = heatingModel.Duration * 3600 * Convert.ToDouble(cost)

        operationsUtils.insert(heatingModel)

        fillDataGrid()

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
End Class
