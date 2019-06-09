Imports System.Data.OleDb
Imports System
Imports System.Data.SqlClient

Public Class input_form
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = C:\Users\Eddi\Documents\Heating_DB1.mdb"
    Dim sql As String ' sql statement

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox_date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_date.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_name.SelectedIndexChanged

    End Sub

    Private Sub Input_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_submit_Click(sender As Object, e As EventArgs) Handles Button_submit.Click

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Try
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter

            con.ConnectionString = dbProvider & dbSource
            con.Open()

            MessageBox.Show("The database is connected")

            sql = "SELECT * FROM Table1"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds)

            ' loading data to DataGridView
            DataGridView1.DataSource = ds.Tables(0)

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class