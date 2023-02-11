Public Class modifier_client


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_ajout.Click
        Dim sql As String = "select * from client where upper(ref_cli)=upper('" & txt_cod_cli.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                MessageBox.Show("client existe deja")
                txt_cod_cli.Clear()
                txt_nom_cli.Clear()
                txt_cod_cli.Focus()
            Else
                Dim sql1 As String = "insert into client values ('" & txt_cod_cli.Text & "','" & txt_nom_cli.Text & "'," & CInt(combo_remise.Text) & ")"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                cmd.ExecuteNonQuery()
                MessageBox.Show("client a été inserer")
                txt_cod_cli.Clear()
                txt_nom_cli.Clear()
                txt_cod_cli.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_modif.Click
        Dim sql As String = "select * from client where upper(ref_cli)=upper('" & txt_cod_cli.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                Dim sql1 As String = "update client set  nom_cli='" & txt_nom_cli.Text & "' ,remise=" & CInt(combo_remise.Text) & " where  upper(ref_cli)=upper('" & txt_cod_cli.Text & "')"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                cmd.ExecuteNonQuery()
                MessageBox.Show("client a été modifier")
                txt_cod_cli.Clear()
                txt_nom_cli.Clear()
                txt_cod_cli.Focus()
            Else
                MessageBox.Show("client n'existe pas")
                txt_cod_cli.Clear()
                txt_nom_cli.Clear()
                txt_cod_cli.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_sup_Click(sender As Object, e As EventArgs) Handles bt_sup.Click
        Dim sql As String = "select * from client where upper(ref_cli)=upper('" & txt_cod_cli.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                Dim sql1 As String = "delete from client where  upper(ref_cli)=upper('" & txt_cod_cli.Text & "')"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                cmd.ExecuteNonQuery()
                MessageBox.Show("client a été modifier")
                txt_cod_cli.Clear()
                txt_nom_cli.Clear()
                txt_cod_cli.Focus()
            Else

                MessageBox.Show("client n'existe pas")
                txt_cod_cli.Clear()
                txt_nom_cli.Clear()
                txt_cod_cli.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_quit_Click(sender As Object, e As EventArgs) Handles bt_quit.Click
        Me.Hide()
        admin.Show()

    End Sub

    Private Sub modifier_client_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        admin.Show()
    End Sub
End Class