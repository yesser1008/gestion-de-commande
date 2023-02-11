Public Class modifier_emp

    Private Sub lk_lib_affiche_MouseDown(sender As Object, e As MouseEventArgs) Handles lk_lib_affiche.MouseDown
        txt_password_emp.UseSystemPasswordChar = False
    End Sub

    Private Sub lk_lib_affiche_MouseUp(sender As Object, e As MouseEventArgs) Handles lk_lib_affiche.MouseUp
        txt_password_emp.UseSystemPasswordChar = True
    End Sub

    Private Sub bt_ajout_Click(sender As Object, e As EventArgs) Handles bt_ajout.Click
        Dim sql As String = "select * from compte where upper(user_name)=upper('" & txt_nom_emp.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                MessageBox.Show("nom d'utilisateur existe deja")
                txt_nom_emp.Clear()
                txt_password_emp.Clear()
                txt_nom_emp.Focus()
            Else
                If tech.Checked Then
                    Dim sql1 As String = "insert into compte values ('" & txt_nom_emp.Text & "','" & txt_password_emp.Text & "'," & "'tech'" & ")"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("responsable de fabrication ajouté")
                    txt_nom_emp.Clear()
                    txt_password_emp.Clear()
                    txt_nom_emp.Focus()

                ElseIf secretaire.Checked Then
                    Dim sql1 As String = "insert into compte values ('" & txt_nom_emp.Text & "','" & txt_password_emp.Text & "'," & "'secretaire'" & ")"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("secretaire ajouté")
                    txt_nom_emp.Clear()
                    txt_password_emp.Clear()
                    txt_nom_emp.Focus()

                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub modifier_emp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        admin.Show()

    End Sub

    Private Sub bt_quit_Click(sender As Object, e As EventArgs) Handles bt_quit.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub bt_modif_Click(sender As Object, e As EventArgs) Handles bt_modif.Click
        Dim sql As String = "select * from compte where upper(user_name)=upper('" & txt_nom_emp.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                If tech.Checked Then
                    Dim sql1 As String = "update compte set  password='" & txt_password_emp.Text & "' ,fonction=" & "'tech'" & " where  upper(user_name)=upper('" & txt_nom_emp.Text & "')"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("compte modifié")
                    txt_nom_emp.Clear()
                    txt_password_emp.Clear()
                    txt_nom_emp.Focus()

                ElseIf secretaire.Checked Then
                    Dim sql1 As String = "update compte set  password='" & txt_password_emp.Text & "' ,fonction=" & "'secretaire'" & " where  upper(user_name)=upper('" & txt_nom_emp.Text & "')"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("compte modifié")
                    txt_nom_emp.Clear()
                    txt_password_emp.Clear()
                    txt_nom_emp.Focus()
                End If
            Else
                MessageBox.Show("compte n'existe pas")
                txt_nom_emp.Clear()
                txt_password_emp.Clear()
                txt_nom_emp.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_sup_Click(sender As Object, e As EventArgs) Handles bt_sup.Click
        Dim sql As String = "select * from compte where upper(user_name)=upper('" & txt_nom_emp.Text & "')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Select Case MsgBox("Your Message", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    dr.Read()
                    If dr.HasRows Then
                        Dim sql1 As String = "delete from compte where  upper(user_name)=upper('" & txt_nom_emp.Text & "')"
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = sql1
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("compte a été suprimer")
                        txt_nom_emp.Clear()
                        txt_password_emp.Clear()
                        txt_nom_emp.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No

        End Select
    End Sub

    Private Sub SecretaireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecretaireToolStripMenuItem.Click
        liste_emps.Show()
        Dim sql As String = "select * from compte where upper(fonction)=upper('secretaire')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            liste_emps.DataGridView1.Rows.Clear()
            Dim i As Integer = 0
            While dr.Read
                liste_emps.DataGridView1.Rows.Add()
                liste_emps.DataGridView1.Rows(i).Cells(0).Value = dr.Item("user_name")
                liste_emps.DataGridView1.Rows(i).Cells(1).Value = dr.Item("password")
                i = i + 1
            End While
        End If
    End Sub

    Private Sub ResponsableFabricationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResponsableFabricationToolStripMenuItem.Click
        liste_emps.Show()
        liste_emps.Text = "responsable de fabrication"
        Dim sql As String = "select * from compte where upper(fonction)=upper('tech')"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            liste_emps.DataGridView1.Rows.Clear()
            Dim i As Integer = 0
            While dr.Read
                liste_emps.DataGridView1.Rows.Add()
                liste_emps.DataGridView1.Rows(i).Cells(0).Value = dr.Item("user_name")
                liste_emps.DataGridView1.Rows(i).Cells(1).Value = dr.Item("password")
                i = i + 1
            End While
        End If
    End Sub
End Class