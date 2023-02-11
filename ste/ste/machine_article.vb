Public Class machine_article
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql1 As String = "delete  from FABRIQUER"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql1
        cmd.ExecuteNonQuery()

        For i As Integer = 0 To DataGridView1.Rows.Count - 2

            sql1 = "insert into FABRIQUER values(" & ds.Tables("fabriquer").Rows(i).Item("QTE_MAX") & ",'" & ds.Tables("fabriquer").Rows(i).Item("COD_MACH") & "','" & ds.Tables("fabriquer").Rows(i).Item("REF_ART") & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql1
            cmd.ExecuteNonQuery()
        Next
        Me.Hide()
        admin.Show()
    End Sub
    Private Sub machine_article_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim sql1 As String = "delete  from FABRIQUER"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql1
        cmd.ExecuteNonQuery()
        For i As Integer = 0 To DataGridView1.Rows.Count - 2

            sql1 = "insert into FABRIQUER values(" & ds.Tables("fabriquer").Rows(i).Item("QTE_MAX") & ",'" & ds.Tables("fabriquer").Rows(i).Item("COD_MACH") & "','" & ds.Tables("fabriquer").Rows(i).Item("REF_ART") & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql1
            cmd.ExecuteNonQuery()
        Next
        Me.Hide()
        admin.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            drow = ds.Tables("fabriquer").NewRow()
            ds.Tables("fabriquer").Rows.Add(drow)
            drow("QTE_MAX") = txt_capacite.Text
            drow("COD_MACH") = combo_cod_mach.Text
            drow("REF_ART") = combo_ref_art.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub machine_article_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        machines_articles()
        machines_()
        article_()

    End Sub
    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow

    End Sub
End Class