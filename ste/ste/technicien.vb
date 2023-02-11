Public Class technicien
    Public Sub commande_tech()
        Try
            Dim sql1 As String = "select * from commande where livraison != 1 order by DAT_LIV_COM,DAT_COM  "
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql1
            dr = cmd.ExecuteReader

            Dim i As Integer = 0
            If dr.HasRows Then
                While dr.Read
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = dr.Item("num_com")
                    DataGridView1.Rows(i).Cells(1).Value = CDate(dr.Item("DAT_COM")).ToShortDateString
                    DataGridView1.Rows(i).Cells(2).Value = CDate(dr.Item("DAT_LIV_COM")).ToShortDateString
                    DataGridView1.Rows(i).Cells(3).Value = "lignes"
                    DataGridView1.Rows(i).Cells(4).Value = "livrer"
                    i = i + 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub technicien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        commande_tech()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 3 Then
            lignes_com.ligne_com.Rows.Clear()
            Dim j As Integer = 0
            Try
                Dim sql As String = "select * from LIGNE_COMMANDE where num_com=" & DataGridView1.Rows(e.RowIndex).Cells(0).Value
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                dr = cmd.ExecuteReader
                While dr.Read
                    lignes_com.ligne_com.Rows.Add()
                    lignes_com.ligne_com.Rows(j).Cells(0).Value = dr.Item("REF_ART")
                    lignes_com.ligne_com.Rows(j).Cells(1).Value = dr.Item("QTE_COM")
                    Dim sql1 As String = "select * from article where REF_ART = '" & dr.Item("REF_ART") & "'"
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    dr1 = cmd.ExecuteReader
                    dr1.Read()
                    If dr1.HasRows Then
                        lignes_com.ligne_com.Rows(j).Cells(2).Value = dr1.Item("MOULE")
                    End If
                    j = j + 1
                End While
                lignes_com.Text = "ligne de commande N°  " & DataGridView1.Rows(e.RowIndex).Cells(0).Value
                lignes_com.Show()
            Catch ex As Exception

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If e.ColumnIndex = 4 Then
            Try
                Dim sql As String = "update commande set LIVRAISON=1 where NUM_COM=" & DataGridView1.Rows(e.RowIndex).Cells(0).Value
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                MessageBox.Show("commande a été livré", "alerte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.Rows.Clear()
                commande_tech()

            Catch ex As Exception

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub bt_rech_machine_Click(sender As Object, e As EventArgs) Handles bt_rech_machine.Click
        Try
            Dim sql As String = "select * from fabriquer where ref_art='" & txt_ref_art.Text & "'"
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            Dim j As Integer = 0

            If dr.HasRows Then
                While dr.Read

                    Dim sql1 As String = "select * from MACHINE where cod_mach='" & dr.Item("cod_mach") & "'"
                    liste_machine.DataGridView1.Rows.Clear()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql1
                    dr1 = cmd.ExecuteReader
                    dr1.Read()
                    liste_machine.DataGridView1.Rows.Add()
                    liste_machine.DataGridView1.Rows(j).Cells(0).Value = dr.Item("cod_mach")
                    liste_machine.DataGridView1.Rows(j).Cells(1).Value = dr.Item("QTE_MAX")
                    liste_machine.DataGridView1.Rows(j).Cells(2).Value = dr1.Item("DISP_MACH")

                    j = j + 1
                End While
                liste_machine.lab_art.Text = txt_ref_art.Text
                liste_machine.Show()
            Else
                MessageBox.Show("verifier la reference de l'arcile", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub technicien_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Text = "admin" Then
            Me.Hide()
            admin.Show()
        Else
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Text = "admin" Then
            Me.Hide()
            admin.Show()
        Else
            Me.Hide()
            Form1.Show()
        End If
    End Sub


End Class