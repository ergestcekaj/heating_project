Public Class Heating_Cost_Calculator
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Calculate.Show()
    End Sub

    Private Sub RankingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankingToolStripMenuItem.Click
        rankForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub E_PARA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        helpinfo.Show()
    End Sub
End Class