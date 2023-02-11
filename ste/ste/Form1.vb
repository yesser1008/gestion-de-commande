Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ouvrir_bd()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "select * from compte where upper('" & txt_nom.Text & "')=upper(user_name) and upper('" & txt_pas.Text & "')=upper(password) "
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            If dr.HasRows Then
                If (dr.Item("fonction") = "administration") Then
                    admin.Show()

                    Me.Hide()
                ElseIf (dr.Item("fonction") = "tech") Then
                    technicien.Show()
                    Me.Hide()
                ElseIf (dr.Item("fonction") = "secretaire") Then
                    commande.Show()
                    commande.Text = "session de : " & dr.Item("user_name")
                    insert_client()
                    num_commande()
                    insert_article()
                    liste_commande()
                    commande.date_liv_com.Value = Today.AddDays(10)
                    Me.Hide()
                End If
            Else
                MessageBox.Show("verifier la vérifier login ou mot de passe ", "erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        fermer_bd()
        End
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        fermer_bd()
        End
    End Sub

    Private Sub txt_pas_TextChanged(sender As Object, e As EventArgs) Handles txt_pas.TextChanged
        If txt_nom.Text <> "" And txt_pas.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub txt_nom_TextChanged(sender As Object, e As EventArgs) Handles txt_nom.TextChanged
        If txt_nom.Text <> "" And txt_pas.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class
