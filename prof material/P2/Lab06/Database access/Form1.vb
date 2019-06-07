Public Class Form1
Imports System.Data.SqlClient

    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = D:\Users\P2\Lab06\fstands.mdb"
    Dim sql As String ' sql statement
    Public Shared conSQLInfo As String = "Data Source=148.81.187.141; Initial Catalog=fstands; User ID=FIT_st; Password=krament1; Integrated Security=false; Persist Security Info=false; Connection Timeout=600"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '======== Fill out listbox with value from SQL Server dataset ===============
        Dim conSQL As SqlConnection
        conSQL = New SqlConnection(conSQLInfo)
        conSQL.Open()

        sql = "SELECT DISTINCT ADRES_FOR FROM forest_stands ORDER BY ADRES_FOR"
        Dim drSQL As SqlDataReader
        Dim commSQL As SqlCommand
        commSQL = New SqlCommand(sql, conSQL)
        drSQL = Nothing
        drSQL = commSQL.ExecuteReader()
        lstbxSpecies.Items.Clear()
        While drSQL.Read()
            lstbxSpecies.Items.Add(drSQL(0))
        End While

        drSQL.Close()
        conSQL.Close()

        '======== Fill out listbox with value from OLEDB dataset (Access) ===============
        con.ConnectionString = dbProvider & dbSource
        con.Open()

        sql = "SELECT DISTINCT ADRES_FOR FROM forest_stands ORDER BY ADRES_FOR"
        Dim dr As OleDb.OleDbDataReader
        Dim comm As OleDb.OleDbCommand
        comm = New OleDb.OleDbCommand(sql, con)
        dr = Nothing
        dr = comm.ExecuteReader()
        lstbxSpecies.Items.Clear()
        While dr.Read()
            lstbxSpecies.Items.Add(dr(0))
        End While

        dr.Close()
        con.Close()

    End Sub

    Private Sub btnTakeData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakeData.Click

        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter

        con.ConnectionString = dbProvider & dbSource
        con.Open()

        sql = "SELECT * FROM forest_stands"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Stand description")

        ' loading data to DataGridView
        myDataGridView.DataSource = ds.Tables("Stand description")

        ' reading values of 2-nd and 3-rd column in first row
        txtADRES_FOR.Text = ds.Tables("Stand description").Rows(0).Item(1)
        txtTREE_SPECI.Text = ds.Tables("Stand description").Rows(0).Item(2)

        con.Close()

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        con.ConnectionString = dbProvider & dbSource
        con.Open()

        sql = "SELECT * FROM forest_stands WHERE ADRES_FOR = '" & lstbxSpecies.SelectedItem & "'"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Stand description")

        myDataGridView.DataSource = ds.Tables("Stand description")
        con.Close()

    End Sub


End Class
