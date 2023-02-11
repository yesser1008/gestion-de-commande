Imports System.Data
Imports Oracle.DataAccess.Client
Module mode_decconcte
    Public da As OracleDataAdapter
    Public da1 As OracleDataAdapter
    Public ds As New DataSet
    Public drow As DataRow
    Public dt As DataTable

    'insertion du table fabriquer dans datagridview
    Public Sub machines_articles()
        ds.Tables.Clear()
        cmd.Connection = cn
        Dim sql As String = "select * from fabriquer "
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        Dim da As New OracleDataAdapter(cmd)
        da1 = da
        Try
            da.Fill(ds, "fabriquer")
            'MessageBox.Show(ds.Tables("fabriquer").Rows.Count)
            machine_article.DataGridView1.DataSource = ds.Tables("fabriquer")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub machines_()
        cmd.Connection = cn
        Dim sql As String = "select COD_MACH from MACHINE "
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        Dim da As New OracleDataAdapter(cmd)
        Dim ligne As DataRow
        da.Fill(ds, "machine")
        For Each ligne In ds.Tables("machine").Rows
            machine_article.combo_cod_mach.Items.Add(ligne.Item("COD_MACH"))
        Next

    End Sub
    'insertion ref_article 
    Public Sub article_()
        cmd.Connection = cn
        Dim sql As String = "select REF_ART from ARTICLE "
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        Dim da As New OracleDataAdapter(cmd)
        Dim ligne As DataRow
        da.Fill(ds, "article")
        For Each ligne In ds.Tables("article").Rows
            machine_article.combo_ref_art.Items.Add(ligne.Item("ref_art"))
        Next
    End Sub
    ' ajout de ligne dans la table  fabriquer 

End Module
