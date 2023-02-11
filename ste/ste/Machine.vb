Public Class Machine
    Private Sub ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Try
            Dim sql As String = "select * from machine where COD_MACH='" & txt_cod_mach.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MessageBox.Show("code machine existe deja", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_cod_mach.Clear()
                txt_nom_mach.Clear()
            Else
                Dim sql1 As String = "insert into machine values ('" & txt_cod_mach.Text & "','" & txt_nom_mach.Text & "'," & "0" & ")"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                cmd.ExecuteNonQuery()
                MessageBox.Show("machine a été ajoutée")
                txt_cod_mach.Clear()
                txt_nom_mach.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        If txt_cod_mach.Text <> "" Then

            Try
                Dim sql As String = "select * from client where COD_MACH='" & txt_cod_mach.Text & "'"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim sql1 As String = "delete from machine where cod_mach= '" & txt_cod_mach.Text & "'"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("machine a été supprimée")
                    txt_cod_mach.Clear()
                    txt_nom_mach.Clear()
                Else
                    MessageBox.Show("code machine n'existe pas ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_cod_mach.Clear()
                    txt_nom_mach.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("vous devez saisir le code de la machine ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Quiter_Click(sender As Object, e As EventArgs) Handles Quiter.Click
        Me.Hide()
        admin.Show()
    End Sub
    Private Sub Machine_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        admin.Show()
    End Sub
End Class