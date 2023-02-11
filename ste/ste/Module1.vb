
Imports System.Data
Imports Oracle.DataAccess.Client

Module Module1
    Public dr As OracleDataReader

    Public dr1 As OracleDataReader
    Public dr2 As OracleDataReader
    Public cn As New OracleConnection
    Public cmd As New OracleCommand
    'ouvrir la base de donnée'
    Public Sub ouvrir_bd()
        Try
            cn.ConnectionString = "data source=xe; user id=p1; password=2098"
            cn.Open()
            If cn.State = ConnectionState.Open Then
                MessageBox.Show("connected")
            Else
                MessageBox.Show("connection failed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'fermer la base de donnée'
    Public Sub fermer_bd()
        Try
            cn.Close()
            If cn.State = ConnectionState.Closed Then
                MessageBox.Show("closed")

            Else
                MessageBox.Show("failed")
            End If
            Try

            Catch ex As Exception
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'insertion de la liste des client dans le formulaire commande'
    Public Sub insert_client()
        Dim sql1 As String = "select * from client"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql1
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                Dim ref = dr.Item("ref_cli")
                commande.ref_cli.Items.Add(ref)
                While dr.Read
                    ref = dr.Item("ref_cli")
                    commande.ref_cli.Items.Add(ref)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'numero de la nouvelle commande'
    Public Sub num_commande()
        Dim sql As String = "select nvl(max(num_com),0) nm_com from commande "
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                commande.txt_num_com.Text = CInt(dr.Item("nm_com")) + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'numero de la nouvelle ligne de commande'
    Public num_lig As Integer
    Public Sub num_ligne()
        Dim sql As String = "select nvl(max(num_ligne),0) nm_lign from LIGNE_COMMANDE "
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                num_lig = CInt(dr.Item("nm_lign")) + 1


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'insertion de la liste des commande dans le formulaire commande'
    Public Sub liste_commande()
        Dim sql1 As String = "select * from commande"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql1
        dr = cmd.ExecuteReader
        commande.liste_com.Items.Clear()
        Try
            dr.Read()
            If dr.HasRows Then
                Dim typ = dr.Item("num_com")
                commande.liste_com.Items.Add(typ)
                While dr.Read
                    typ = dr.Item("num_com")
                    commande.liste_com.Items.Add(typ)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'insertion de la liste des articles dans le formulaire commande'
    Public Sub insert_article()
        Dim sql1 As String = "select * from article"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql1
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            If dr.HasRows Then
                Dim ref = dr.Item("ref_art")
                commande.txt_num_art.Items.Add(ref)
                While dr.Read
                    ref = dr.Item("ref_art")
                    commande.txt_num_art.Items.Add(ref)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'recherche de machine 
    Public Sub rech_machine()
        Try
            Dim sql As String = "select * from fabriquer where ref_art='" & liste_machine.lab_art.Text & "'"
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
            Else
                MessageBox.Show("verifier la reference de l'arcile", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
