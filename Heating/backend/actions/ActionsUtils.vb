Public Class ActionsUtils

    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim dbSource As String = "Data Source =C:\Users\Eddi\source\repos\heating_project\Heating\bin\Debug\Heating_DB.mdb"
    Dim sql As String ' sql statement

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetInstance As ActionsUtils
        Get
            Static Instance As ActionsUtils = New ActionsUtils
            Return Instance
        End Get
    End Property

    Public Sub insert(heatingModel As Heating)
        con.ConnectionString = dbProvider & dbSource
        con.Open()

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
