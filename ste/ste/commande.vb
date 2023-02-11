Public Class commande

    Private Sub date_com_ValueChanged(sender As Object, e As EventArgs) Handles date_com.ValueChanged
        date_com.Value = Date.Now
    End Sub
    Public remise As Double
    Private Sub typcli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ref_cli.SelectedIndexChanged
        Dim sql As String = "select * from client where ref_cli='" & ref_cli.Text & "'"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                txt_nom_cli.Text = dr.Item("nom_cli")
                remise = CDbl(dr.Item("REMISE")) / 100
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub commande_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Text = "admin" Then
            Me.Hide()
            admin.Show()
        Else
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub txt_num_art_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_num_art.SelectedIndexChanged
        Dim sql As String = "select * from article where ref_art='" & txt_num_art.Text & "'"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                txt_prix.Text = CDbl(dr.Item("prix_art"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_ajout.Click
        Dim verif As Boolean = False
        If data_liste_com.Rows.Count <> 1 Then

            For j As Integer = 0 To data_liste_com.Rows.Count - 1
                If data_liste_com.Rows(j).Cells(0).Value = txt_num_art.Text Then
                    Dim result As DialogResult = MessageBox.Show("voulez vous continuez ?", "modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'suppression d'une commande
                    If result = DialogResult.Yes Then
                        MessageBox.Show(j)
                        mnt_tot.Text = CDbl(mnt_tot.Text) - CDbl(data_liste_com.Rows(j).Cells(3).Value)
                        data_liste_com.Rows(j).Cells(3).Value = txt_mnt_ligne.Text
                        data_liste_com.Rows(j).Cells(2).Value = txt_qtite.Text
                        mnt_tot.Text = CDbl(mnt_tot.Text) + CDbl(txt_mnt_ligne.Text)
                        verif = True
                        Exit For
                    Else
                        j = j + 1
                    End If
                End If
            Next

        End If
        i = data_liste_com.Rows.Count - 1
        If verif = False Then
            data_liste_com.Rows.Add()
            data_liste_com.Rows(i).Cells(0).Value = txt_num_art.Text
            data_liste_com.Rows(i).Cells(1).Value = txt_prix.Text
            data_liste_com.Rows(i).Cells(2).Value = txt_qtite.Text
            data_liste_com.Rows(i).Cells(3).Value = txt_mnt_ligne.Text
            i = i + 1
            mnt_tot.Text = CDbl(mnt_tot.Text) + CDbl(txt_mnt_ligne.Text)
        End If
        txt_num_art.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_enreg.Click
        Try
            Dim Sql As String = "insert into COMMANDE values(" & txt_num_com.Text & ",'" & CStr(date_com.Value).Substring(0, 10) & "','" & CStr(date_liv_com.Value).Substring(0, 10) & "'," & CStr(mnt_tot.Text).Replace(",", ".") & ",'" & ref_cli.Text & "'," & 0 & " )"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()

            num_ligne()

            For l As Integer = 0 To data_liste_com.Rows.Count - 2
                num_lig = num_lig + 1

                Dim sql1 As String = "insert into LIGNE_COMMANDE values (" & num_lig & ",'" & data_liste_com.Rows(l).Cells(0).Value & "'," & data_liste_com.Rows(l).Cells(2).Value & "," & CStr(data_liste_com.Rows(l).Cells(3).Value).Replace(",", ".") & "," & txt_num_com.Text & ")"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                cmd.ExecuteNonQuery()
            Next

            num_commande()
            ref_cli.Text = ""
            txt_nom_cli.Text = ""

            MessageBox.Show("commande passée")

            liste_commande()
            txt_num_art.Text = ""
            txt_prix.Text = ""
            txt_qtite.Text = ""
            txt_mnt_ligne.Text = ""
            mnt_tot.Text = "0,0"
            data_liste_com.Rows.Clear()
            liste_com.Text = ""
            SaveFileDialog1.ShowDialog()

        Catch ex As Exception
            Try
                Dim sql2 As String = "delete from commande where num_com=" & txt_num_com.Text & ")"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql2
                cmd.ExecuteNonQuery()
                num_commande()


            Catch ex1 As Exception
                MessageBox.Show(ex1.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub

    Private Sub txt_qtite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtite.KeyPress
        If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) = 8) Then
        Else
            e.Handled = True
        End If
        If (Asc(e.KeyChar) = 13) Then
            If txt_qtite.Text = "" Then
                MessageBox.Show("vous devez saisie la quantité")
            Else
                txt_mnt_ligne.Text = CDbl(txt_qtite.Text) * (CDbl(txt_prix.Text) * (1 - remise))
                bt_ajout.Focus()
            End If
        End If
    End Sub

    Private Sub txt_prix_TextChanged(sender As Object, e As EventArgs) Handles txt_prix.TextChanged
        If txt_prix.Text <> "" Then
            txt_qtite.Enabled = True
            txt_qtite.Focus()
        Else
            txt_qtite.Enabled = False
        End If
    End Sub

    Private Sub bt_ajout_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bt_ajout.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            txt_num_art.Focus()
        End If
    End Sub
    Dim first As Integer
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bt_rech.Click

        txt_num_com.Text = liste_com.Text

        'recherche de la commande
        Dim sql As String = "select * from commande where num_com=" & txt_num_com.Text & ""
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader

        'recherche des lignes de la commande
        Dim sql1 As String = "select * from LIGNE_COMMANDE where num_com=" & txt_num_com.Text & ""
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql1
        dr1 = cmd.ExecuteReader

        Try
            dr.Read()
            If dr.HasRows Then
                txt_num_com.Text = dr.Item("num_com")
                date_com.Value = CDate(CStr(dr.Item("DAT_COM")).Substring(0, 10))
                ref_cli.Text = dr.Item("ref_cli")
                date_liv_com.Value = CDate(CStr(dr.Item("DAT_LIV_COM")).Substring(0, 10))
                mnt_tot.Text = dr.Item("mnt_tot_com")
            End If
            Dim prix As String
            Try
                If dr1.HasRows Then
                    data_liste_com.Rows.Clear()
                    Dim num_ligne As Integer = 0
                    While dr1.Read()
                        data_liste_com.Rows.Add()
                        'selection du prix de chaque article
                        Dim sql2 As String = "select prix_art from article where ref_art='" & dr1.Item("ref_art") & "'"
                        cmd.Connection = cn
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = sql2
                        dr2 = cmd.ExecuteReader
                        Try
                            dr2.Read()
                            If dr2.HasRows Then
                                prix = CDbl(dr2.Item("prix_art"))
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        data_liste_com.Rows(num_ligne).Cells(0).Value = dr1.Item("ref_art")
                        data_liste_com.Rows(num_ligne).Cells(1).Value = prix
                        data_liste_com.Rows(num_ligne).Cells(2).Value = dr1.Item("QTE_COM")
                        data_liste_com.Rows(num_ligne).Cells(3).Value = dr1.Item("MNT_LIG_COM")

                        num_ligne = num_ligne + 1
                    End While
                End If
                first = data_liste_com.Rows.Count
            Catch ex As Exception
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'insertion du nom du client
        Dim sql3 As String = "select * from client where ref_cli='" & ref_cli.Text & "'"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql3
        dr = cmd.ExecuteReader

        Try
            dr.Read()
            If dr.HasRows Then
                txt_nom_cli.Text = dr.Item("nom_cli")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bt_sup_Click(sender As Object, e As EventArgs) Handles bt_sup.Click
        Dim result As DialogResult = MessageBox.Show("voulez vous continuez ?", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'suppression d'une commande
        If result = DialogResult.Yes Then
            Try
                Dim sql As String = "delete from commande where num_com=" & txt_num_com.Text & ""
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                MessageBox.Show("commande a été supprimée")
                num_commande()
                ref_cli.Text = ""
                txt_nom_cli.Text = ""
                txt_num_art.Text = ""
                txt_prix.Text = ""
                txt_qtite.Text = ""
                txt_mnt_ligne.Text = ""
                mnt_tot.Text = "0,0"
                data_liste_com.Rows.Clear()
                liste_com.Text = ""
                bt_sup.Enabled = False
                bt_modif.Enabled = False
                bt_enreg.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            liste_commande()
        End If


    End Sub

    Private Sub txt_num_com_TextChanged(sender As Object, e As EventArgs) Handles txt_num_com.TextChanged
        'modification de l'utilisabilité des boutton de mise a jour 
        If txt_num_com.Text <> "" Then
            Dim sql As String = "select NUM_COM from commande where num_com=" & txt_num_com.Text & ""
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dr = cmd.ExecuteReader

            dr.Read()
            If dr.HasRows Then
                bt_sup.Enabled = True
                bt_modif.Enabled = True
                bt_enreg.Enabled = False
            Else
                bt_sup.Enabled = False
                bt_modif.Enabled = False
                bt_enreg.Enabled = True
            End If

        End If


    End Sub

    Private Sub liste_com_SelectedIndexChanged(sender As Object, e As EventArgs) Handles liste_com.SelectedIndexChanged
        'bouton recherche 
        If liste_com.Text IsNot "" Then
            bt_rech.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'selon l'utilisateur
        If Text = "admin" Then
            Me.Hide()
            admin.Show()
        Else
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bt_anul.Click
        num_commande()
        liste_commande()
        ref_cli.Text = ""
        txt_nom_cli.Text = ""
        txt_num_art.Text = ""
        txt_prix.Text = ""
        txt_qtite.Text = ""
        txt_mnt_ligne.Text = ""
        mnt_tot.Text = "0,0"
        data_liste_com.Rows.Clear()
        liste_com.Text = ""
    End Sub

    Private Sub bt_modif_Click(sender As Object, e As EventArgs) Handles bt_modif.Click

        'modification des lignes qui sont deja inserer à la base de donnée
        For l As Integer = 0 To first - 2
            Try
                Dim sql1 As String = "update  LIGNE_COMMANDE set  QTE_COM=" & data_liste_com.Rows(l).Cells(2).Value & ",MNT_LIG_COM=" & CStr(data_liste_com.Rows(l).Cells(3).Value).Replace(",", ".") & " where NUM_COM=" & txt_num_com.Text & " and REF_ART='" & data_liste_com.Rows(l).Cells(0).Value & "'"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        'insertion des nouveau lignes
        Dim second As Integer = data_liste_com.Rows.Count
        num_ligne()
        If second > first Then

            For l As Integer = first - 1 To second - 2
                num_lig = num_lig + 1
                Try
                    MessageBox.Show(l)
                    Dim sql1 As String = "insert into LIGNE_COMMANDE values (" & num_lig & ",'" & data_liste_com.Rows(l).Cells(0).Value & "'," & data_liste_com.Rows(l).Cells(2).Value & "," & CStr(data_liste_com.Rows(l).Cells(3).Value).Replace(",", ".") & "," & txt_num_com.Text & ")"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

        End If
        'modification du date de livraison
        Try
            Dim sql1 As String = "update  commande set  DAT_LIV_COM='" & CStr(date_liv_com.Value).Substring(0, 10) & "', MNT_TOT_COM=" & CStr(mnt_tot.Text).Replace(",", ".")
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql1
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ref_cli.Text = ""
            txt_nom_cli.Text = ""

            MessageBox.Show("commande modifiée")
        num_commande()
        liste_commande()
        txt_num_art.Text = ""
            txt_prix.Text = ""
            txt_qtite.Text = ""
            txt_mnt_ligne.Text = ""
            mnt_tot.Text = "0,0"
            data_liste_com.Rows.Clear()
        liste_com.Text = ""

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        'pour enregistrer la commande sous forme pdf 
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter Filename to create PDF")
            Exit Sub
        Else
            ExportDataToPDFTable()
            MsgBox("PDF saved Successfully")
        End If
    End Sub




End Class





