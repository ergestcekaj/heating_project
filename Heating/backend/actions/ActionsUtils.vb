Public Class ActionsUtils
    'The action class is created to separate the database actions from the rest of the operation in the application


    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Heating_DB.mdb"
    Dim sql As String ' sql statement

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetInstance As ActionsUtils
        'This class is a singleton
        Get
            Static Instance As ActionsUtils = New ActionsUtils
            Return Instance
        End Get
    End Property

    Public Sub insert(heatingModel As Heating)
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        'After opening the connection with the database we insert values in the database table

        Dim Sql = "INSERT INTO HEATING ([NAME],[DURATION],[MONTHS],[COST]) VALUES(Name,Duration,Month,Cost)"
        Dim Com = New OleDb.OleDbCommand(Sql, con)
        Com.Parameters.AddWithValue("@Name", heatingModel.Name)
        Com.Parameters.AddWithValue("@Duration", heatingModel.Duration)
        Com.Parameters.AddWithValue("@Month", heatingModel.months)
        Com.Parameters.AddWithValue("@Cost", heatingModel.cost)

        Com.ExecuteNonQuery()
        con.Close()


    End Sub

    Public Function fetchAllHeatingData() As DataSet
        Dim ds As New DataSet
        'After taking the values from the database we input them into the datagrid
        ' In case nothing is selected in the filter, the database is shown as complete
        Try
            Dim da As OleDb.OleDbDataAdapter

            con.ConnectionString = dbProvider & dbSource
            con.Open()

            sql = "SELECT * FROM HEATING"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds)

            con.Close()
        Catch ex As Exception
            MessageBox.Show("The database is NOT connected")
        End Try
        Return ds
    End Function

    Public Function filterData(filter As Filter) As DataSet
        Dim ds As New DataSet
        'Here the user can select the desired month or user and show the costs of the heating per user or month and the total cost
        Try
            Dim da As OleDb.OleDbDataAdapter

            con.ConnectionString = dbProvider & dbSource
            con.Open()

            sql = "SELECT * FROM HEATING where Name in(" + createINConditionFromSelectedVaues(filter.Name_list) + ") and Months in(" + createINConditionFromSelectedVaues(filter.Month_list) + ")"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds)

            con.Close()
        Catch ex As Exception
            MessageBox.Show("The database is NOT connected")
        End Try
        Return ds
    End Function

    Private Function createINConditionFromSelectedVaues(list As ArrayList) As String
        Dim inClause As String = ""
        For index As Integer = 0 To list.Count - 1
            inClause += "'" + list.Item(index) + "'" + ","
        Next

        Return inClause.Trim().Remove(inClause.Length - 1)
    End Function

End Class
