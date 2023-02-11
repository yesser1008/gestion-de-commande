Imports System.ComponentModel

Public Class admin
    Private Sub tech_Click(sender As Object, e As EventArgs) Handles bt_tech.Click
        Me.Hide()
        technicien.Show()
        technicien.Text = "admin"

    End Sub

    Private Sub commande_Click(sender As Object, e As EventArgs) Handles bt_commande.Click

        Me.Hide()
        commande.Text = "admin"
        commande.Show()

        insert_client()
        num_commande()
        insert_article()
        liste_commande()
        commande.date_liv_com.Value = Today.AddDays(10)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt_mod_cli.Click
        Me.Hide()
        modifier_client.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_quiter.Click

        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub admin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub bt_mod_emp_Click(sender As Object, e As EventArgs) Handles bt_mod_emp.Click
        Me.Hide()
        modifier_emp.Show()
    End Sub

    Private Sub bt_art_Click(sender As Object, e As EventArgs) Handles bt_art.Click
        Me.Hide()
        articles.Show()

    End Sub

    Private Sub bt_mach_Click(sender As Object, e As EventArgs) Handles bt_mach.Click
        Me.Hide()
        Machine.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'insertion des code des machines   
        '       Dim sql As String = "select * from machine"
        '       cmd.CommandType = CommandType.Text
        '      cmd.CommandText = sql
        '     dr = cmd.ExecuteReader
        '    Try

        'While dr.Read
        'machine_article.combo_cod_mach.Items.Add(dr.Item("cod_mach"))
        'End While
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

        '        'insertion de la liste des article combo_ref_art
        '       Dim sql1 As String = "select * from article"
        '      cmd.CommandType = CommandType.Text
        '     cmd.CommandText = sql1
        '    dr = cmd.ExecuteReader
        '   Try
        '  While dr.Read
        ' machine_article.combo_ref_art.Items.Add(dr.Item("REF_ART"))
        'End While
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try


        Me.Hide()
        machine_article.Show()

    End Sub


End Class