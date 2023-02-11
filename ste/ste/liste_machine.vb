Public Class liste_machine


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.ColumnIndex = 0 Then
            If DataGridView1.Rows(e.RowIndex).Cells(2).Value = "1" Then
                bt_libre.Enabled = True
            Else
                bt_aff.Enabled = True
            End If
            txt_cod.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Try


                Dim sql1 As String = "select * from MACHINE where cod_mach='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'"
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql1
                dr1 = cmd.ExecuteReader
                dr1.Read()
                txt_nom.Text = dr1.Item("NOM_MACH")
            Catch ex As Exception

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub bt_libre_Click(sender As Object, e As EventArgs) Handles bt_libre.Click
        Try


            Dim sql As String = "update MACHINE set DISP_MACH= 0 where cod_mach='" & txt_cod.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MessageBox.Show("opération se fait avec succès")
            txt_cod.Clear()
            txt_nom.Clear()
            DataGridView1.Rows.Clear()
            rech_machine()
            bt_libre.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bt_aff_Click(sender As Object, e As EventArgs) Handles bt_aff.Click
        Try


            Dim sql As String = "update MACHINE set DISP_MACH= 1 where cod_mach='" & txt_cod.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MessageBox.Show("opération se fait avec succès")
            txt_cod.Clear()
            txt_nom.Clear()
            DataGridView1.Rows.Clear()
            rech_machine()
            bt_aff.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class