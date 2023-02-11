Public Class articles
    Private Sub Radio_all_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_all.CheckedChanged
        Try
            If Radio_all.Checked Then
                DataGridView1.Rows.Clear()
                Dim Sql As String = "select * from article "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = Sql
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim i As Integer = 0
                    While dr.Read()
                        DataGridView1.Rows.Add()
                        DataGridView1.Rows(i).Cells(0).Value = dr.Item("ref_art")
                        DataGridView1.Rows(i).Cells(1).Value = dr.Item("typ_art")
                        DataGridView1.Rows(i).Cells(2).Value = dr.Item("prix_art")
                        i = i + 1
                    End While
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bt_ajout_Click(sender As Object, e As EventArgs) Handles bt_ajout.Click
        DataGridView1.Rows.Clear()
        Try
            Dim Sql As String = "select * from article where ref_art='" & txt_ref_art.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Sql
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("reference article existe deja")
                txt_ref_art.Clear()
                txt_typ_art.Clear()
                txt_prix_art.Clear()
                txt_ref_art.Focus()
            Else
                Sql = "insert into article values ('" & txt_ref_art.Text & "','" & txt_typ_art.Text & "'," & txt_prix_art.Text & ",'" & txt_moule.Text & "')"
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()
                MessageBox.Show("article a été ajouté .")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bt_modif_Click(sender As Object, e As EventArgs) Handles bt_modif.Click
        Dim sql As String = "select * from article where ref_art='" & txt_ref_art.Text & "'"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                sql = "update article set  prix_art=" & CStr(txt_prix_art.Text).Replace(",", ".") & " where ref_art='" & txt_ref_art.Text & "'"
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                MessageBox.Show("article a été modifié")
                DataGridView1.Rows.Clear()
            Else
                MessageBox.Show("article n'existe pas")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub radio_part_CheckedChanged(sender As Object, e As EventArgs) Handles radio_part.CheckedChanged
        Try
            If radio_part.Checked Then
                DataGridView1.Rows.Clear()
                Dim Sql As String = "select * from article where ref_art != any(select ref_art from ligne_commande) "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = Sql
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim i As Integer = 0
                    While dr.Read()
                        'remplissage du  data grid view a partir de la requete select 
                        DataGridView1.Rows.Add()
                        DataGridView1.Rows(i).Cells(0).Value = dr.Item("ref_art")
                        DataGridView1.Rows(i).Cells(1).Value = dr.Item("typ_art")
                        DataGridView1.Rows(i).Cells(2).Value = dr.Item("prix_art")
                        i = i + 1
                    End While
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bt_suprimer_Click(sender As Object, e As EventArgs) Handles bt_suprimer.Click
        Dim sql As String = "select * from commande where num_com = any (select num_com from LIGNE_COMMANDE where ref_art='" & txt_ref_art.Text & "')"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Dim verif As Boolean = False
        If dr.HasRows Then
            While dr.Read And verif = False
                If dr.Item("LIVRAISON") = 0 Then
                    MessageBox.Show("l'article existe deja dans une  commande en cours", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    verif = True
                End If
            End While
        End If
        If verif = False Then

            Try
                dr.Read()
                If dr.HasRows Then
                    sql = "delete from article where ref_art='" & txt_ref_art.Text & "'"
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("article a été supprimé")
                Else
                    MessageBox.Show("article n'existe pas")
                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub bt_quit_Click(sender As Object, e As EventArgs) Handles bt_quit.Click
        Me.Hide()
        admin.Show()
    End Sub
    Private Sub articles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        admin.Show()
    End Sub
End Class