Public Class DB_form
    Public Sub saveuser(User_name As String, pass_txt As String, Question As String, answer_txt As String, bytImage() As Byte)
        con.ConnectionString = dbProvider & dbSource
        con.Open()

        Dim Sql = "INSERT INTO Heating_DB1.table1 ([name],[Duration],[Date],[Cost]) VALUES(ComboBox_name,TextBox_duration,ComboBox_dat)"
        Dim Com = New OleDb.OleDbCommand(Sql, con)
        Com.Parameters.AddWithValue("@User_name", User_name)
        Com.Parameters.AddWithValue("@password", pass_txt)
        Com.Parameters.AddWithValue("@Question", Question)
        Com.Parameters.AddWithValue("@Answer", answer_txt)
        Com.Parameters.AddWithValue("@Image", bytImage)

        Dim dr As OleDbDataReader
        Com.ExecuteNonQuery()


    End Sub
    Private Sub DB_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class